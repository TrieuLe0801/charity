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
        public string parentPath = System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();

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

        public void SaveDataTable(DataTable dt, String filePath)
        {
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

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    xlWorkSheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                }

                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= dt.Columns.Count - 1; j++)
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }
                }
                xlApp.DisplayAlerts = false;
                xlWorkBook.SaveAs(filePath); 
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

        public void SaveDataGridView(DataGridView dg, String filePath)
        {
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

                for (int i = 0; i < dg.Columns.Count; i++)
                {
                    xlWorkSheet.Cells[1, i + 1] = dg.Columns[i].Name;
                }

                for (int i = 0; i <= dg.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= dg.Columns.Count - 1; j++)
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = dg.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xlApp.DisplayAlerts = false;
                xlWorkBook.SaveAs(filePath);
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

        public void ReadSample(DataGridView dataGridView, DataTable dataTable)
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
                        row = dataTable.NewRow();
                    for (int j = 1; j <= colCount; j++)
                    {
                        if (i == 1)
                            dataTable.Columns.Add(excelRange.Cells[1, j].value);
                        else
                        {
                            if(!String.IsNullOrEmpty(excelRange.Cells[i, 1].value2.ToString()))
                            {
                                row[j - 1] = excelRange.Cells[i, j].value;
                            }
                        }
                    }
                    if (row != null && !String.IsNullOrEmpty(row[@"Id"].ToString()))
                        dataTable.Rows.Add(row);
                }
                dataGridView.DataSource = dataTable;
                excelWorkbook.Close();
                excelApp.Quit();
            }
        }
        public addData()
        {
            InitializeComponent();
            ReadSample(gridview, dtexcel);
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

            charityData.dateCharity = this.dateTimePicker1.Value.Date;
            charityData.numberMoney = float.Parse(moneyField.Text, CultureInfo.InvariantCulture);
            charityData.inOutMoney = inOutcmbobox.Text;
            charityData.commentCharity = cmtBox.Text;
            if (dtexcel.Rows.Count > 0)
            {
                DataRow row = dtexcel.AsEnumerable().Last();
                lastId = Int32.Parse(row[@"Id"].ToString()) + 1;
                workRow = dtexcel.NewRow();
            }
            else
            {
           
                charityData.id = 0;
                workRow = dtexcel.NewRow();
                Console.WriteLine(dtexcel.Rows.Count);
            }
            charityData.id = lastId;
            workRow[@"Id"] = charityData.id;
            workRow[@"Thu/Chi"] = charityData.inOutMoney;
            workRow[@"Ngày"] = charityData.dateCharity;
            workRow[@"Số Tiền"] = charityData.numberMoney;
            workRow[@"Ghi Chú"] = charityData.commentCharity;
            dtexcel.Rows.Add(workRow);

            //save data
            SaveDataGridView(gridview, parentPath + @"\test.xlsx");
            this.dateTimePicker1.Value = DateTime.Now;
            this.inOutcmbobox.SelectedIndex = 0;
            this.moneyField.Text = "0";
            this.cmtBox.Text = "";
        }

        private void moneyField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.dateTimePicker1.Value = DateTime.Now;
            this.inOutcmbobox.SelectedIndex = 0;
            this.moneyField.Text = "0";
            this.cmtBox.Text = "";
        }
    }
}
