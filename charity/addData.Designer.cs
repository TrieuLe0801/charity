namespace charity
{
    partial class addData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addData));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cmtBox = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.moneyField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.inOutcmbobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.cmtBox);
            this.groupBox.Controls.Add(this.dateTimePicker1);
            this.groupBox.Controls.Add(this.moneyField);
            this.groupBox.Controls.Add(this.label12);
            this.groupBox.Controls.Add(this.cancelBtn);
            this.groupBox.Controls.Add(this.addBtn);
            this.groupBox.Controls.Add(this.inOutcmbobox);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox.Location = new System.Drawing.Point(88, 11);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(759, 199);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Add data";
            // 
            // cmtBox
            // 
            this.cmtBox.Location = new System.Drawing.Point(544, 76);
            this.cmtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmtBox.Name = "cmtBox";
            this.cmtBox.Size = new System.Drawing.Size(198, 70);
            this.cmtBox.TabIndex = 8;
            this.cmtBox.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 30);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 24);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // moneyField
            // 
            this.moneyField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moneyField.Location = new System.Drawing.Point(544, 32);
            this.moneyField.Name = "moneyField";
            this.moneyField.Size = new System.Drawing.Size(197, 24);
            this.moneyField.TabIndex = 3;
            this.moneyField.Text = "0";
            this.moneyField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moneyField_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(410, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số tiền";
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Location = new System.Drawing.Point(211, 154);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(98, 30);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Location = new System.Drawing.Point(484, 154);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(98, 30);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Ghi thông tin";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // inOutcmbobox
            // 
            this.inOutcmbobox.CausesValidation = false;
            this.inOutcmbobox.DisplayMember = "Category";
            this.inOutcmbobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inOutcmbobox.FormattingEnabled = true;
            this.inOutcmbobox.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.inOutcmbobox.Location = new System.Drawing.Point(176, 72);
            this.inOutcmbobox.Name = "inOutcmbobox";
            this.inOutcmbobox.Size = new System.Drawing.Size(197, 23);
            this.inOutcmbobox.TabIndex = 2;
            this.inOutcmbobox.Tag = "";
            this.inOutcmbobox.Text = "Thu";
            this.inOutcmbobox.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F);
            this.label3.Location = new System.Drawing.Point(41, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thu/Chi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F);
            this.label2.Location = new System.Drawing.Point(41, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày";
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Location = new System.Drawing.Point(392, 425);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(151, 30);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // gridview
            // 
            this.gridview.AllowUserToAddRows = false;
            this.gridview.AllowUserToDeleteRows = false;
            this.gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(89, 216);
            this.gridview.Name = "gridview";
            this.gridview.ReadOnly = true;
            this.gridview.Size = new System.Drawing.Size(757, 185);
            this.gridview.TabIndex = 7;
            // 
            // addData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 473);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.exitBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "addData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uoc_mo_xanh";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox moneyField;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox inOutcmbobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox cmtBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridView gridview;
    }
}