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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_random = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudUShortValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoolAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUShortAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBOOLSetting
            // 
            this.btnBOOLSetting.Location = new System.Drawing.Point(434, 87);
            this.btnBOOLSetting.Name = "btnBOOLSetting";
            this.btnBOOLSetting.Size = new System.Drawing.Size(75, 23);
            this.btnBOOLSetting.TabIndex = 0;
            this.btnBOOLSetting.Text = "写入";
            this.btnBOOLSetting.UseVisualStyleBackColor = true;
            this.btnBOOLSetting.Click += new System.EventHandler(this.btnBOOLSetting_Click);
            // 
            // lblBOOL
            // 
            this.lblBOOL.AutoSize = true;
            this.lblBOOL.Location = new System.Drawing.Point(42, 66);
            this.lblBOOL.Name = "lblBOOL";
            this.lblBOOL.Size = new System.Drawing.Size(53, 12);
            this.lblBOOL.TabIndex = 1;
            this.lblBOOL.Text = "开关型：";
            // 
            // lblUShort
            // 
            this.lblUShort.AutoSize = true;
            this.lblUShort.Location = new System.Drawing.Point(42, 127);
            this.lblUShort.Name = "lblUShort";
            this.lblUShort.Size = new System.Drawing.Size(53, 12);
            this.lblUShort.TabIndex = 2;
            this.lblUShort.Text = "模拟量：";
            // 
            // cboBool
            // 
            this.cboBool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBool.FormattingEnabled = true;
            this.cboBool.Location = new System.Drawing.Point(42, 87);
            this.cboBool.Name = "cboBool";
            this.cboBool.Size = new System.Drawing.Size(121, 20);
            this.cboBool.TabIndex = 3;
            this.cboBool.SelectedIndexChanged += new System.EventHandler(this.cboBool_SelectedIndexChanged);
            // 
            // cboUShort
            // 
            this.cboUShort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUShort.FormattingEnabled = true;
            this.cboUShort.Location = new System.Drawing.Point(42, 154);
            this.cboUShort.Name = "cboUShort";
            this.cboUShort.Size = new System.Drawing.Size(121, 20);
            this.cboUShort.TabIndex = 4;
            this.cboUShort.SelectedIndexChanged += new System.EventHandler(this.cboUShort_SelectedIndexChanged);
            // 
            // lblBoolValue
            // 
            this.lblBoolValue.AutoSize = true;
            this.lblBoolValue.Location = new System.Drawing.Point(297, 67);
            this.lblBoolValue.Name = "lblBoolValue";
            this.lblBoolValue.Size = new System.Drawing.Size(29, 12);
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
            this.cboBoolValue.Location = new System.Drawing.Point(297, 88);
            this.cboBoolValue.Name = "cboBoolValue";
            this.cboBoolValue.Size = new System.Drawing.Size(121, 20);
            this.cboBoolValue.TabIndex = 6;
            // 
            // lblUShortValue
            // 
            this.lblUShortValue.AutoSize = true;
            this.lblUShortValue.Location = new System.Drawing.Point(297, 127);
            this.lblUShortValue.Name = "lblUShortValue";
            this.lblUShortValue.Size = new System.Drawing.Size(29, 12);
            this.lblUShortValue.TabIndex = 7;
            this.lblUShortValue.Text = "值：";
            // 
            // nudUShortValue
            // 
            this.nudUShortValue.Location = new System.Drawing.Point(297, 154);
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
            this.nudUShortValue.Size = new System.Drawing.Size(120, 21);
            this.nudUShortValue.TabIndex = 8;
            // 
            // btnUShortSetting
            // 
            this.btnUShortSetting.Location = new System.Drawing.Point(434, 153);
            this.btnUShortSetting.Name = "btnUShortSetting";
            this.btnUShortSetting.Size = new System.Drawing.Size(75, 23);
            this.btnUShortSetting.TabIndex = 9;
            this.btnUShortSetting.Text = "写入";
            this.btnUShortSetting.UseVisualStyleBackColor = true;
            this.btnUShortSetting.Click += new System.EventHandler(this.btnUShortSetting_Click);
            // 
            // btnComSetting
            // 
            this.btnComSetting.Location = new System.Drawing.Point(42, 25);
            this.btnComSetting.Name = "btnComSetting";
            this.btnComSetting.Size = new System.Drawing.Size(75, 23);
            this.btnComSetting.TabIndex = 10;
            this.btnComSetting.Text = "串口设置";
            this.btnComSetting.UseVisualStyleBackColor = true;
            this.btnComSetting.Click += new System.EventHandler(this.btnComSetting_Click);
            // 
            // lblBoolAddress
            // 
            this.lblBoolAddress.AutoSize = true;
            this.lblBoolAddress.Location = new System.Drawing.Point(178, 66);
            this.lblBoolAddress.Name = "lblBoolAddress";
            this.lblBoolAddress.Size = new System.Drawing.Size(41, 12);
            this.lblBoolAddress.TabIndex = 11;
            this.lblBoolAddress.Text = "地址：";
            // 
            // lblUShortAddress
            // 
            this.lblUShortAddress.AutoSize = true;
            this.lblUShortAddress.Location = new System.Drawing.Point(178, 127);
            this.lblUShortAddress.Name = "lblUShortAddress";
            this.lblUShortAddress.Size = new System.Drawing.Size(41, 12);
            this.lblUShortAddress.TabIndex = 12;
            this.lblUShortAddress.Text = "地址：";
            // 
            // nudBoolAddress
            // 
            this.nudBoolAddress.Location = new System.Drawing.Point(178, 87);
            this.nudBoolAddress.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudBoolAddress.Name = "nudBoolAddress";
            this.nudBoolAddress.Size = new System.Drawing.Size(104, 21);
            this.nudBoolAddress.TabIndex = 13;
            // 
            // nudUShortAddress
            // 
            this.nudUShortAddress.Location = new System.Drawing.Point(178, 154);
            this.nudUShortAddress.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudUShortAddress.Name = "nudUShortAddress";
            this.nudUShortAddress.Size = new System.Drawing.Size(104, 21);
            this.nudUShortAddress.TabIndex = 14;
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(127, 30);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(77, 12);
            this.lblMemo.TabIndex = 15;
            this.lblMemo.Text = "状态：未联机";
            // 
            // button_exportReport
            // 
            this.button_exportReport.Location = new System.Drawing.Point(588, 88);
            this.button_exportReport.Margin = new System.Windows.Forms.Padding(2);
            this.button_exportReport.Name = "button_exportReport";
            this.button_exportReport.Size = new System.Drawing.Size(81, 22);
            this.button_exportReport.TabIndex = 16;
            this.button_exportReport.Text = "导出报表";
            this.button_exportReport.UseVisualStyleBackColor = true;
            this.button_exportReport.Click += new System.EventHandler(this.button_exportReport_Click);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(508, 295);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(500, 375);
            this.cartesianChart1.TabIndex = 17;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(0, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(500, 375);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "测试序号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "体积";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "压力";
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "测试结果：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "统计分析：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 22);
            this.button1.TabIndex = 21;
            this.button1.Text = "打印报表";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_random
            // 
            this.button_random.Location = new System.Drawing.Point(588, 213);
            this.button_random.Name = "button_random";
            this.button_random.Size = new System.Drawing.Size(81, 23);
            this.button_random.TabIndex = 22;
            this.button_random.Text = "随机数据";
            this.button_random.UseVisualStyleBackColor = true;
            this.button_random.Click += new System.EventHandler(this.button_random_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 694);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(641, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "说明：点击随机数据按钮可以随机生成曲线图，修改体积和压力值可以动态修改曲线图，数据表格中的数据可以导出报表";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_random);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cartesianChart1);
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
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLC示例";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUShortValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoolAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUShortAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_random;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label3;
    }
}

