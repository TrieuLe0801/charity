using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using charity.Data;
using System.Globalization;

namespace charity
{
    public partial class addData : Form
    {
        // Set the grid's column names from row 1.
        private void SetGridColumns(DataGridView dgv,
            object[,] values, int max_col)
        {
            gridview.Columns.Clear();

            // Get the title values.
            for (int col = 1; col <= max_col; col++)
            {
                string title = (string)values[1, col];
                dgv.Columns.Add(title, title);
            }
        }

        // Set the grid's contents.
        private void SetGridContents(DataGridView dgv,
            object[,] values, int max_row, int max_col)
        {
            // Copy the values into the grid.
            for (int row = 2; row <= max_row; row++)
            {
                object[] row_values = new object[max_col];
                for (int col = 1; col <= max_col; col++)
                    row_values[col - 1] = values[row, col];
                dgv.Rows.Add(row_values);
            }
        }

        public void ReadSample()
        {
            Excel.Application excelApp = new Excel.Application();
            if (excelApp != null)
            {
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(@"D:\work\charity\test.xlsx", 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

                Excel.Range excelRange = excelWorksheet.UsedRange;
                int rowCount = excelRange.Rows.Count;
                int colCount = excelRange.Columns.Count;

                // Get the sheet's values.
                object[,] values = (object[,])excelRange.Value2;

                // Get the column titles.
                SetGridColumns(gridview, values, colCount);

                // Get the data.
                SetGridContents(gridview, values, rowCount, colCount);

                //for (int i = 1; i <= rowCount; i++)
                //{
                //    for (int j = 1; j <= colCount; j++)
                //    {
                //        Excel.Range range = (excelWorksheet.Cells[i, j] as Excel.Range);
                //        if(range.Value != null)
                //        {
                //            string cellValue = range.Value.ToString();
                //            Console.WriteLine(cellValue);
                //        }
                        
                //        //do anything
                //    }
                //}

                excelWorkbook.Close();
                excelApp.Quit();
            }
        }
        public addData()
        {
            InitializeComponent();
            ReadSample();
            //String name = "Sheet1";
            //String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            //                @"D:\work\charity\test.xlsx" +
            //                ";Extended Properties='Excel 8.0;HDR=YES;';";

            //OleDbConnection con = new OleDbConnection(constr);
            //OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
            //con.Open();

            //OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            //DataTable data = new DataTable();
            //sda.Fill(data);
            //gridview.DataSource = data;
            //gridview.Visible = true;

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int numberRows = 0;
            int lastId = 0;
            DataRow workRow;
            Data.Data charityData = new Data.Data();
            DataTable dtexcel = new DataTable();
            for(int i = 0; i< gridview.Columns.Count; i++)
            {
                Console.WriteLine(gridview.Columns[i].Name);
                dtexcel.Columns.Add(gridview.Columns[i].Name);
            }
            //dtexcel = gridview.DataSource as DataTable;
            charityData.dateCharity = this.dateTimePicker1.Value.Date;
            charityData.numberMoney = float.Parse(moneyField.Text, CultureInfo.InvariantCulture);
            charityData.inOutMoney = inOutcmbobox.Text;
            charityData.commentCharity = cmtBox.Text;
            if (gridview.DataSource != null)
            {
                Console.WriteLine(dtexcel.Rows.Count);
                dtexcel = gridview.DataSource as DataTable;
                lastId = dtexcel.Rows.Count;
                charityData.id = lastId;
                workRow = dtexcel.NewRow();
                workRow[@"Id"] = charityData.id;
                workRow[@"Thu/Chi"] = charityData.inOutMoney;
                workRow[@"Ngày"] = charityData.dateCharity;
                workRow[@"Số Tiền"] = charityData.numberMoney;
                workRow[@"Ghi Chú"] = charityData.commentCharity;
                dtexcel.Rows.Add(workRow);
                gridview.DataSource = dtexcel;
            }
            else
            {
                Console.WriteLine(0);
                charityData.id = 0;
                workRow = dtexcel.NewRow();
                workRow[@"Id"] = charityData.id;
                workRow[@"Thu/Chi"] = charityData.inOutMoney;
                workRow[@"Ngày"] = charityData.dateCharity;
                workRow[@"Số Tiền"] = charityData.numberMoney;
                workRow[@"Ghi Chú"] = charityData.commentCharity;
                dtexcel.Rows.Add(workRow);
                gridview.Columns.Clear();
                gridview.DataSource = dtexcel;

            }
            
            
            //if (!float.TryParse(moneyField.Text, out _))
            //{
            //    MessageBox.Show(@"Hãy điền số vào ô này");
            //}
            //else
            //{
                
            //}
        }
    }
}
