namespace charity
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridViewReport = new System.Windows.Forms.DataGridView();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.searchBtn = new System.Windows.Forms.Button();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sumLb = new System.Windows.Forms.Label();
            this.outMoneyLb = new System.Windows.Forms.Label();
            this.inMoneyLb = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewReport
            // 
            this.gridViewReport.AllowUserToAddRows = false;
            this.gridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewReport.Location = new System.Drawing.Point(105, 105);
            this.gridViewReport.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewReport.Name = "gridViewReport";
            this.gridViewReport.Size = new System.Drawing.Size(998, 261);
            this.gridViewReport.TabIndex = 8;
            this.gridViewReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewReport_CellClick);
            this.gridViewReport.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewReport_CellEndEdit);
            this.gridViewReport.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridViewReport_EditingControlShowing);
            this.gridViewReport.SelectionChanged += new System.EventHandler(this.gridViewReport_SelectionChanged);
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.Location = new System.Drawing.Point(140, 53);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(200, 22);
            this.dateFromPicker.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Đến ngày";
            // 
            // dateToPicker
            // 
            this.dateToPicker.Location = new System.Drawing.Point(409, 53);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(200, 22);
            this.dateToPicker.TabIndex = 11;
            // 
            // searchBtn
            // 
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Location = new System.Drawing.Point(661, 48);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(131, 37);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Hiển thị";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // showAllBtn
            // 
            this.showAllBtn.AutoSize = true;
            this.showAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showAllBtn.Location = new System.Drawing.Point(818, 48);
            this.showAllBtn.Margin = new System.Windows.Forms.Padding(4);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(131, 37);
            this.showAllBtn.TabIndex = 13;
            this.showAllBtn.Text = "Hiển thị toàn bộ";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Location = new System.Drawing.Point(504, 532);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(201, 37);
            this.exitBtn.TabIndex = 14;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sumLb);
            this.groupBox1.Controls.Add(this.outMoneyLb);
            this.groupBox1.Controls.Add(this.inMoneyLb);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(105, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(997, 141);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // sumLb
            // 
            this.sumLb.AutoSize = true;
            this.sumLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumLb.Location = new System.Drawing.Point(152, 87);
            this.sumLb.Name = "sumLb";
            this.sumLb.Size = new System.Drawing.Size(50, 25);
            this.sumLb.TabIndex = 17;
            this.sumLb.Text = "0.00";
            // 
            // outMoneyLb
            // 
            this.outMoneyLb.AutoSize = true;
            this.outMoneyLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outMoneyLb.Location = new System.Drawing.Point(152, 57);
            this.outMoneyLb.Name = "outMoneyLb";
            this.outMoneyLb.Size = new System.Drawing.Size(50, 25);
            this.outMoneyLb.TabIndex = 17;
            this.outMoneyLb.Text = "0.00";
            // 
            // inMoneyLb
            // 
            this.inMoneyLb.AutoSize = true;
            this.inMoneyLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inMoneyLb.Location = new System.Drawing.Point(152, 27);
            this.inMoneyLb.Name = "inMoneyLb";
            this.inMoneyLb.Size = new System.Drawing.Size(50, 25);
            this.inMoneyLb.TabIndex = 17;
            this.inMoneyLb.Text = "0.00";
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Location = new System.Drawing.Point(817, 80);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(131, 37);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Xóa dữ liệu";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBtn.Location = new System.Drawing.Point(817, 22);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(131, 37);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Lưu chỉnh sửa";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tổng quỹ:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tổng chi:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tổng thu:";
            // 
            // resetBtn
            // 
            this.resetBtn.AutoSize = true;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Location = new System.Drawing.Point(972, 48);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(131, 37);
            this.resetBtn.TabIndex = 13;
            this.resetBtn.Text = "Hủy thay đổi";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 582);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateToPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFromPicker);
            this.Controls.Add(this.gridViewReport);
            this.MaximizeBox = false;
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewReport;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sumLb;
        private System.Windows.Forms.Label outMoneyLb;
        private System.Windows.Forms.Label inMoneyLb;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetBtn;
    }
}