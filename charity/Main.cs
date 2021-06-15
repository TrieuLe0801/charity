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
    }
}
