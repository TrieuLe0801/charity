using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charity
{
    public partial class Report : Form
    {
        public addData addData = new addData();
        public DataTable dtReport = new DataTable();
        public DataTable dtCloned = new DataTable();
        public DataTable dtReflesh = new DataTable();
        public charity.Data.Data itemData = new charity.Data.Data();
        public float totalInMoney = 0;
        public float totalOutMoney = 0;
        public float totalSumary = 0;
        public ArrayList listChairtyData = new ArrayList();
        public void UpdateValueReport(DataTable dt)
        {
            // calculate in money
            totalInMoney = dt.AsEnumerable().Where(row => row.Field<string>(@"Thu/Chi") == "Thu").Sum(row => row.Field<float>(@"Số Tiền"));
            inMoneyLb.Text = string.Format("{0:#,##0.00} VND", float.Parse(totalInMoney.ToString()));

            // calculate out money
            totalOutMoney = dt.AsEnumerable().Where(row => row.Field<string>(@"Thu/Chi") == "Chi").Sum(row => row.Field<float>(@"Số Tiền"));
            outMoneyLb.Text = string.Format("{0:#,##0.00} VND", float.Parse(totalOutMoney.ToString()));

            // calculate sumary
            totalSumary = totalInMoney - totalOutMoney;
            sumLb.Text = string.Format("{0:#,##0.00} VND", float.Parse(totalSumary.ToString()));
        }
        public Report()
        {
            InitializeComponent();
            addData.ReadSample(gridViewReport, dtReport);
            DataTable dtCloned = dtReport.Clone();
            dtCloned.Columns[@"Id"].DataType = typeof(Int32);
            dtCloned.Columns[@"Ngày"].DataType = typeof(DateTime);
            dtCloned.Columns[@"Số Tiền"].DataType = typeof(float);
            foreach (DataRow row in dtReport.Rows)
            {
                dtCloned.ImportRow(row);
            }
            // update type for table report
            dtReport = dtCloned;
            dtReflesh = dtCloned;
            //gridViewReport.DataSource = dtReport;
            UpdateValueReport(dtReport);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            gridViewReport.DataSource = dtReport;
            dtReflesh = dtReport;
            UpdateValueReport(dtReport);
            this.dateFromPicker.Value = DateTime.Now;
            this.dateToPicker.Value = DateTime.Now;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate, endDate = new DateTime();
            startDate = this.dateFromPicker.Value.Date;
            endDate = this.dateToPicker.Value.Date;
            if(startDate <= endDate)
            {
                var filerRows = dtReport.AsEnumerable().Where(row => (row.Field<DateTime>(@"Ngày") >= startDate) && (row.Field<DateTime>(@"Ngày") <= endDate));
                var filterTable = dtReport.Clone();
                foreach (DataRow row in filerRows)
                {
                    filterTable.ImportRow(row);
                }
                gridViewReport.DataSource = filterTable;
                dtReflesh = filterTable;
                UpdateValueReport(filterTable);
            }
            else
            {
                MessageBox.Show(@"Kiểm tra lại ngày bắt đầu và ngày kết thúc. Hãy đảm bảo ngày bắt đầu giá trị bé hơn ngày kết thúc.",
                    @"Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.dateFromPicker.Value = DateTime.Now;
                this.dateToPicker.Value = DateTime.Now;
            }
        }

        private void gridViewReport_SelectionChanged(object sender, EventArgs e)
        {
            listChairtyData = new ArrayList();
            foreach (DataGridViewRow row in gridViewReport.SelectedRows)
            {
                itemData.id = Int32.Parse(row.Cells[@"Id"].Value.ToString());
                itemData.dateCharity = DateTime.Parse(row.Cells[@"Ngày"].Value.ToString());
                itemData.inOutMoney = row.Cells[@"Thu/Chi"].Value.ToString();
                itemData.numberMoney = float.Parse(row.Cells[@"Số Tiền"].Value.ToString());
                itemData.commentCharity = row.Cells[@"Ghi Chú"].Value.ToString();
                listChairtyData.Add(itemData);
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listChairtyData.Count > 0)
            {
                DialogResult res = MessageBox.Show(@"Bạn chắc chắn muốn xóa những dòng này?",
                    @"Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
                {
                    Console.WriteLine($"list data items:{listChairtyData.Count}");
                    foreach(charity.Data.Data dataRow in listChairtyData)
                    {
                        gridViewReport.Rows.Cast<DataGridViewRow>().Where(r => Int32.Parse(r.Cells[@"Id"].Value.ToString()) == dataRow.id).ToList().ForEach(r => gridViewReport.Rows.Remove(r));
                        dtReport.Rows.Cast<DataRow>().Where(r => r.Field<int>(@"Id") == dataRow.id).ToList().ForEach(r => r.Delete());
                    }
                    DataTable filterTable = (DataTable)gridViewReport.DataSource; ;
                    UpdateValueReport(filterTable);
                    addData.SaveDataTable(dtReport, addData.parentPath + @"\test.xlsx");

                }
                else
                {
                    gridViewReport.ClearSelection();
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(@"Bạn chắc chắn muốn lưu lại những dòng này?",
                    @"Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                listChairtyData = new ArrayList();
                foreach (DataGridViewRow row in gridViewReport.Rows)
                {
                    itemData.id = Int32.Parse(row.Cells[@"Id"].Value.ToString());
                    itemData.dateCharity = DateTime.Parse(row.Cells[@"Ngày"].Value.ToString());
                    itemData.inOutMoney = row.Cells[@"Thu/Chi"].Value.ToString();
                    itemData.numberMoney = float.Parse(row.Cells[@"Số Tiền"].Value.ToString());
                    itemData.commentCharity = row.Cells[@"Ghi Chú"].Value.ToString();
                    dtReport.Rows.Cast<DataRow>().Where(r => r.Field<int>(@"Id") == itemData.id).ToList().ForEach(r =>
                    {
                        r[@"Ngày"] = itemData.dateCharity;
                        r[@"Thu/Chi"] = itemData.inOutMoney;
                        r[@"Số Tiền"] = itemData.numberMoney;
                        r[@"Ghi Chú"] = itemData.commentCharity;
                    });
                }
                DataTable filterTable = (DataTable)gridViewReport.DataSource;
                UpdateValueReport(filterTable);
                addData.SaveDataTable(dtReport, addData.parentPath + @"\test.xlsx");
            }
            else
            {
                gridViewReport.DataSource = dtReflesh;
                UpdateValueReport(dtReflesh);
            }
        }

        private void gridViewReport_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(addData.moneyField_KeyPress);
            if(gridViewReport.CurrentCell.ColumnIndex == gridViewReport.Columns[@"Số Tiền"].Index)
            {
                TextBox tb = e.Control as TextBox;
                if(tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(addData.moneyField_KeyPress);
                }
            }
        }
    }
}
