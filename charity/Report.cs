using System;
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
        public DataTable dtReport = new DataTable();
        public DataTable dtCloned = new DataTable();
        public float totalInMoney = 0;
        public float totalOutMoney = 0;
        public float totalSumary = 0;
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
            addData addData = new addData();
            InitializeComponent();
            addData.ReadSample(gridViewReport, dtReport);
            DataTable dtCloned = dtReport.Clone();
            dtCloned.Columns[@"Id"].DataType = typeof(Int32);
            dtCloned.Columns[@"Ngày"].DataType = typeof(DateTime);
            dtCloned.Columns[@"Số Tiền"].DataType = typeof(float);
            foreach (DataRow row in dtReport.Rows)
            {
                dtCloned.ImportRow(row);
                Console.WriteLine(dtCloned.Columns[@"Ngày"].DataType);
            }
            // update type for table report
            dtReport = dtCloned;
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
            UpdateValueReport(dtReport);
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
    }
}
