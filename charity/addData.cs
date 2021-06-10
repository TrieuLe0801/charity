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
        public DataTable dtexcel = new DataTable();
        Excel.Application excelApp = new Excel.Application();
        string parentPath = System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
        // Set the grid's column names from row 1.
        private void SetGridColumns(DataGridView dgv,
            object[,] values, int max_col)
        {
            dgv.Columns.Clear();

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
                DataRow Row = dtexcel.NewRow();
                for (int col = 1; col <= max_col; col++)
                    if(values[row, col] != null)
                    {
                        row_values[col - 1] = values[row, col].ToString();
                    }
                dgv.Rows.Add(row_values);
                //else
                //{
                //    row_values[col - 1] = values[row, col];
                //}
            }
        }

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        public void ReadSample()
        {
            if (excelApp != null)
            {
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(parentPath + @"\test.xlsx", 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

                Excel.Range excelRange = excelWorksheet.UsedRange;
                int rowCount = excelRange.Rows.Count;
                int colCount = excelRange.Columns.Count;
                DataRow row = null;
                for (int i = 1; i <= rowCount; i++)
                {
                    if (i != 1)
                        row = dtexcel.NewRow();
                    for (int j = 1; j <= colCount; j++)
                    {
                        if (i == 1)
                            dtexcel.Columns.Add(excelRange.Cells[1, j].value);
                        else
                            row[j - 1] = excelRange.Cells[i, j].value;
                    }
                    if (row != null)
                        dtexcel.Rows.Add(row);
                }
                gridview.DataSource = dtexcel;

                //// Get the sheet's values.
                //object[,] values = (object[,])excelRange.Value2;

                //// Get the column titles.
                //SetGridColumns(gridview, values, colCount);

                //// Get the data.
                //SetGridContents(gridview, values, rowCount, colCount);

                excelWorkbook.Close();
                excelApp.Quit();
            }
        }
        public addData()
        {
            InitializeComponent();
            ReadSample();
            Console.WriteLine(dtexcel.Rows.Count);
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
            //DataTable dtexcel = new DataTable();
            
            charityData.dateCharity = this.dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
            charityData.numberMoney = float.Parse(moneyField.Text, CultureInfo.InvariantCulture);
            charityData.inOutMoney = inOutcmbobox.Text;
            charityData.commentCharity = cmtBox.Text;
            if (dtexcel.Rows.Count > 0)
            {
                Console.WriteLine($"Pass {gridview.Rows.Count}");
                //dtexcel = gridview.DataSource as DataTable;
                lastId = dtexcel.Rows.Count;
                workRow = dtexcel.NewRow();
            }
            else
            {
           
                charityData.id = 0;
                workRow = dtexcel.NewRow();
                gridview.Columns.Clear();
            }
            charityData.id = lastId;
            workRow[@"Id"] = charityData.id;
            workRow[@"Thu/Chi"] = charityData.inOutMoney;
            workRow[@"Ngày"] = charityData.dateCharity;
            workRow[@"Số Tiền"] = charityData.numberMoney;
            workRow[@"Ghi Chú"] = charityData.commentCharity;
            dtexcel.Rows.Add(workRow);
            //dtexcel.AcceptChanges();
            //gridview.Rows.Clear();
            //gridview.Columns.Clear();
            //gridview.Refresh();
            gridview.DataSource = dtexcel;

            //save data
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            try
            {
                //Previous code was referring to the wrong class, throwing an exception
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                for (int i = 0; i < gridview.Columns.Count; i++)
                {
                    xlWorkSheet.Cells[1, i + 1] = gridview.Columns[i].Name;
                }

                for (int i = 0; i <= gridview.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= gridview.Columns.Count - 1; j++)
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = gridview.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xlApp.DisplayAlerts = false;
                xlWorkBook.SaveAs(parentPath + @"\test.xlsx");
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlApp);
                releaseObject(xlWorkBook);
                releaseObject(xlWorkSheet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void moneyField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
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
