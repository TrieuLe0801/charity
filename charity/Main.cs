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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addDataBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            addData addData = new addData();
            addData.Show();
            this.Hide();
            Cursor.Current = Cursors.Default;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Report report = new Report();
            report.Show();
            this.Hide();
            Cursor.Current = Cursors.Default;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string filePath = string.Empty;
            saveFileDialog.InitialDirectory = System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            saveFileDialog.Filter = "excel files (*.xls)|*.xls|*.xlsx|*.xlsx";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.Title = "Export File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                addData addData = new addData();
                DataTable dataTable = new DataTable();
                if (saveFileDialog.FileName != null)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    filePath = saveFileDialog.FileName;
                    addData.ReadSample(null, dataTable);
                    addData.SaveDataTable(dataTable, filePath);
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(@"Toàn bộ dữ liệu đã được xuất ra file excel",
                     @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
