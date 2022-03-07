namespace HaiwellPLCDemo
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnBOOLSetting = new System.Windows.Forms.Button();
            this.lblBOOL = new System.Windows.Forms.Label();
            this.lblUShort = new System.Windows.Forms.Label();
            this.cboBool = new System.Windows.Forms.ComboBox();
            this.cboUShort = new System.Windows.Forms.ComboBox();
            this.lblBoolValue = new System.Windows.Forms.Label();
            this.cboBoolValue = new System.Windows.Forms.ComboBox();
            this.lblUShortValue = new System.Windows.Forms.Label();
            this.nudUShortValue = new System.Windows.Forms.NumericUpDown();
            this.btnUShortSetting = new System.Windows.Forms.Button();
            this.btnComSetting = new System.Windows.Forms.Button();
            this.lblBoolAddress = new System.Windows.Forms.Label();
            this.lblUShortAddress = new System.Windows.Forms.Label();
            this.nudBoolAddress = new System.Windows.Forms.NumericUpDown();
            this.nudUShortAddress = new System.Windows.Forms.NumericUpDown();
            this.lblMemo = new System.Windows.Forms.Label();
            this.button_exportReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudUShortValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoolAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUShortAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBOOLSetting
            // 
            this.btnBOOLSetting.Location = new System.Drawing.Point(579, 109);
            this.btnBOOLSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnBOOLSetting.Name = "btnBOOLSetting";
            this.btnBOOLSetting.Size = new System.Drawing.Size(100, 29);
            this.btnBOOLSetting.TabIndex = 0;
            this.btnBOOLSetting.Text = "写入";
            this.btnBOOLSetting.UseVisualStyleBackColor = true;
            this.btnBOOLSetting.Click += new System.EventHandler(this.btnBOOLSetting_Click);
            // 
            // lblBOOL
            // 
            this.lblBOOL.AutoSize = true;
            this.lblBOOL.Location = new System.Drawing.Point(56, 82);
            this.lblBOOL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBOOL.Name = "lblBOOL";
            this.lblBOOL.Size = new System.Drawing.Size(67, 15);
            this.lblBOOL.TabIndex = 1;
            this.lblBOOL.Text = "开关型：";
            // 
            // lblUShort
            // 
            this.lblUShort.AutoSize = true;
            this.lblUShort.Location = new System.Drawing.Point(56, 159);
            this.lblUShort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUShort.Name = "lblUShort";
            this.lblUShort.Size = new System.Drawing.Size(67, 15);
            this.lblUShort.TabIndex = 2;
            this.lblUShort.Text = "模拟量：";
            // 
            // cboBool
            // 
            this.cboBool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBool.FormattingEnabled = true;
            this.cboBool.Location = new System.Drawing.Point(56, 109);
            this.cboBool.Margin = new System.Windows.Forms.Padding(4);
            this.cboBool.Name = "cboBool";
            this.cboBool.Size = new System.Drawing.Size(160, 23);
            this.cboBool.TabIndex = 3;
            this.cboBool.SelectedIndexChanged += new System.EventHandler(this.cboBool_SelectedIndexChanged);
            // 
            // cboUShort
            // 
            this.cboUShort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUShort.FormattingEnabled = true;
            this.cboUShort.Location = new System.Drawing.Point(56, 192);
            this.cboUShort.Margin = new System.Windows.Forms.Padding(4);
            this.cboUShort.Name = "cboUShort";
            this.cboUShort.Size = new System.Drawing.Size(160, 23);
            this.cboUShort.TabIndex = 4;
            this.cboUShort.SelectedIndexChanged += new System.EventHandler(this.cboUShort_SelectedIndexChanged);
            // 
            // lblBoolValue
            // 
            this.lblBoolValue.AutoSize = true;
            this.lblBoolValue.Location = new System.Drawing.Point(396, 84);
            this.lblBoolValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoolValue.Name = "lblBoolValue";
            this.lblBoolValue.Size = new System.Drawing.Size(37, 15);
            this.lblBoolValue.TabIndex = 5;
            this.lblBoolValue.Text = "值：";
            // 
            // cboBoolValue
            // 
            this.cboBoolValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoolValue.FormattingEnabled = true;
            this.cboBoolValue.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cboBoolValue.Location = new System.Drawing.Point(396, 110);
            this.cboBoolValue.Margin = new System.Windows.Forms.Padding(4);
            this.cboBoolValue.Name = "cboBoolValue";
            this.cboBoolValue.Size = new System.Drawing.Size(160, 23);
            this.cboBoolValue.TabIndex = 6;
            // 
            // lblUShortValue
            // 
            this.lblUShortValue.AutoSize = true;
            this.lblUShortValue.Location = new System.Drawing.Point(396, 159);
            this.lblUShortValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUShortValue.Name = "lblUShortValue";
            this.lblUShortValue.Size = new System.Drawing.Size(37, 15);
            this.lblUShortValue.TabIndex = 7;
            this.lblUShortValue.Text = "值：";
            // 
            // nudUShortValue
            // 
            this.nudUShortValue.Location = new System.Drawing.Point(396, 192);
            this.nudUShortValue.Margin = new System.Windows.Forms.Padding(4);
            this.nudUShortValue.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudUShortValue.Minimum = new decimal(new int[] {
            65536,
            0,
            0,
            -2147483648});
            this.nudUShortValue.Name = "nudUShortValue";
            this.nudUShortValue.Size = new System.Drawing.Size(160, 25);
            this.nudUShortValue.TabIndex = 8;
            // 
            // btnUShortSetting
            // 
            this.btnUShortSetting.Location = new System.Drawing.Point(579, 191);
            this.btnUShortSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnUShortSetting.Name = "btnUShortSetting";
            this.btnUShortSetting.Size = new System.Drawing.Size(100, 29);
            this.btnUShortSetting.TabIndex = 9;
            this.btnUShortSetting.Text = "写入";
            this.btnUShortSetting.UseVisualStyleBackColor = true;
            this.btnUShortSetting.Click += new System.EventHandler(this.btnUShortSetting_Click);
            // 
            // btnComSetting
            // 
            this.btnComSetting.Location = new System.Drawing.Point(56, 31);
            this.btnComSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnComSetting.Name = "btnComSetting";
            this.btnComSetting.Size = new System.Drawing.Size(100, 29);
            this.btnComSetting.TabIndex = 10;
            this.btnComSetting.Text = "串口设置";
            this.btnComSetting.UseVisualStyleBackColor = true;
            this.btnComSetting.Click += new System.EventHandler(this.btnComSetting_Click);
            // 
            // lblBoolAddress
            // 
            this.lblBoolAddress.AutoSize = true;
            this.lblBoolAddress.Location = new System.Drawing.Point(237, 82);
            this.lblBoolAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoolAddress.Name = "lblBoolAddress";
            this.lblBoolAddress.Size = new System.Drawing.Size(52, 15);
            this.lblBoolAddress.TabIndex = 11;
            this.lblBoolAddress.Text = "地址：";
            // 
            // lblUShortAddress
            // 
            this.lblUShortAddress.AutoSize = true;
            this.lblUShortAddress.Location = new System.Drawing.Point(237, 159);
            this.lblUShortAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUShortAddress.Name = "lblUShortAddress";
            this.lblUShortAddress.Size = new System.Drawing.Size(52, 15);
            this.lblUShortAddress.TabIndex = 12;
            this.lblUShortAddress.Text = "地址：";
            // 
            // nudBoolAddress
            // 
            this.nudBoolAddress.Location = new System.Drawing.Point(237, 109);
            this.nudBoolAddress.Margin = new System.Windows.Forms.Padding(4);
            this.nudBoolAddress.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudBoolAddress.Name = "nudBoolAddress";
            this.nudBoolAddress.Size = new System.Drawing.Size(139, 25);
            this.nudBoolAddress.TabIndex = 13;
            // 
            // nudUShortAddress
            // 
            this.nudUShortAddress.Location = new System.Drawing.Point(237, 192);
            this.nudUShortAddress.Margin = new System.Windows.Forms.Padding(4);
            this.nudUShortAddress.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudUShortAddress.Name = "nudUShortAddress";
            this.nudUShortAddress.Size = new System.Drawing.Size(139, 25);
            this.nudUShortAddress.TabIndex = 14;
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(169, 38);
            this.lblMemo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(97, 15);
            this.lblMemo.TabIndex = 15;
            this.lblMemo.Text = "状态：未联机";
            // 
            // button_exportReport
            // 
            this.button_exportReport.Location = new System.Drawing.Point(784, 110);
            this.button_exportReport.Name = "button_exportReport";
            this.button_exportReport.Size = new System.Drawing.Size(108, 28);
            this.button_exportReport.TabIndex = 16;
            this.button_exportReport.Text = "导出报表";
            this.button_exportReport.UseVisualStyleBackColor = true;
            this.button_exportReport.Click += new System.EventHandler(this.button_exportReport_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.button_exportReport);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.nudUShortAddress);
            this.Controls.Add(this.nudBoolAddress);
            this.Controls.Add(this.lblUShortAddress);
            this.Controls.Add(this.lblBoolAddress);
            this.Controls.Add(this.btnComSetting);
            this.Controls.Add(this.btnUShortSetting);
            this.Controls.Add(this.nudUShortValue);
            this.Controls.Add(this.lblUShortValue);
            this.Controls.Add(this.cboBoolValue);
            this.Controls.Add(this.lblBoolValue);
            this.Controls.Add(this.cboUShort);
            this.Controls.Add(this.cboBool);
            this.Controls.Add(this.lblUShort);
            this.Controls.Add(this.lblBOOL);
            this.Controls.Add(this.btnBOOLSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLC示例";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUShortValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoolAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUShortAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBOOLSetting;
        private System.Windows.Forms.Label lblBOOL;
        private System.Windows.Forms.Label lblUShort;
        private System.Windows.Forms.ComboBox cboBool;
        private System.Windows.Forms.ComboBox cboUShort;
        private System.Windows.Forms.Label lblBoolValue;
        private System.Windows.Forms.ComboBox cboBoolValue;
        private System.Windows.Forms.Label lblUShortValue;
        private System.Windows.Forms.NumericUpDown nudUShortValue;
        private System.Windows.Forms.Button btnUShortSetting;
        private System.Windows.Forms.Button btnComSetting;
        private System.Windows.Forms.Label lblBoolAddress;
        private System.Windows.Forms.Label lblUShortAddress;
        private System.Windows.Forms.NumericUpDown nudBoolAddress;
        private System.Windows.Forms.NumericUpDown nudUShortAddress;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.Button button_exportReport;
    }
}

