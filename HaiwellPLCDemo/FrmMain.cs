using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace HaiwellPLCDemo
{
    public partial class FrmMain : Form
    {
        private Modbus.Device.ModbusMaster modbusMaster;
        private ComConfigModel ComConfigModel;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.LoadVariableInfo();
            this.cboBoolValue.SelectedIndex = 0;

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(3),
                        new ObservableValue(5),
                        new ObservableValue(2),
                        new ObservableValue(7),
                        new ObservableValue(7),
                        new ObservableValue(4)
                    },
                    PointGeometrySize = 0,
                    StrokeThickness = 4,
                    Fill = Brushes.Transparent
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(3),
                        new ObservableValue(4),
                        new ObservableValue(6),
                        new ObservableValue(8),
                        new ObservableValue(7),
                        new ObservableValue(5)
                    },
                    PointGeometrySize = 0,
                    StrokeThickness = 4,
                    Fill = Brushes.Transparent
                }
            };

            cartesianChart1.Series = SeriesCollection;

            dataGridView1.Rows.Add(new object[] { 1, 1, 1 });
            dataGridView1.Rows.Add(new object[] { 2, 5, 7 });
            dataGridView1.Rows.Add(new object[] { 3, 3, 9 });
            dataGridView1.Rows.Add(new object[] { 4, 6, 3 });
            dataGridView1.Rows.Add(new object[] { 5, 5, 8 });
            dataGridView1.Rows.Add(new object[] { 6, 9, 1 });
        }

        public SeriesCollection SeriesCollection { get; set; }

        private void UpdateAllOnClick(object sender, RoutedEventArgs e)
        {
            var r = new Random();

            foreach (var series in SeriesCollection)
            {
                foreach (var observable in series.Values.Cast<ObservableValue>())
                {
                    observable.Value = r.Next(0, 10);
                }
            }
        }

        private void LoadVariableInfo()
        {
            List<VariableInfo> lst = VariableInfo.GetVariableInfos();
            foreach (VariableInfo variableInfo in lst)
            {
                if (variableInfo.IsBool)
                {
                    this.cboBool.Items.Add(variableInfo);
                    if (variableInfo.Name == "Y")
                    {
                        this.cboBool.SelectedItem = variableInfo;
                    }
                }
            }
            foreach (VariableInfo variableInfo in lst)
            {
                if (!variableInfo.IsBool)
                {
                    this.cboUShort.Items.Add(variableInfo);
                    if (variableInfo.Name == "V")
                    {
                        this.cboUShort.SelectedItem = variableInfo;
                    }
                }
            }
        }

        private void btnComSetting_Click(object sender, EventArgs e)
        {
            FrmSerialPortConfig frmSerialPortConfig = new FrmSerialPortConfig();
            if (frmSerialPortConfig.ShowDialog(this) == DialogResult.OK)
            {
                if (this.modbusMaster != null)
                {
                    this.modbusMaster.Dispose();
                }
                this.ComConfigModel = frmSerialPortConfig.ComConfigModel;
                SerialPort sp = frmSerialPortConfig.ComConfigModel.OpenSerialPort();
                this.modbusMaster = Modbus.Device.ModbusSerialMaster.CreateRtu(sp);
                this.lblMemo.Text = $"状态：已联机，{this.ComConfigModel.PortName}";
            }
        }

        private void cboBool_SelectedIndexChanged(object sender, EventArgs e)
        {
            VariableInfo variableInfo = this.cboBool.SelectedItem as VariableInfo;
            if (variableInfo != null)
            {
                this.btnBOOLSetting.Enabled = variableInfo.AllowWrite;
                this.nudBoolAddress.Maximum = variableInfo.End = variableInfo.Start;
            }
        }

        private void cboUShort_SelectedIndexChanged(object sender, EventArgs e)
        {
            VariableInfo variableInfo = this.cboBool.SelectedItem as VariableInfo;
            if (variableInfo != null)
            {
                this.btnUShortSetting.Enabled = variableInfo.AllowWrite;
                this.nudUShortAddress.Maximum = variableInfo.End = variableInfo.Start;
            }
        }

        private void btnBOOLSetting_Click(object sender, EventArgs e)
        {
            if (this.modbusMaster != null)
            {
                VariableInfo variableInfo = this.cboBool.SelectedItem as VariableInfo;
                if (variableInfo != null)
                {
                    try
                    {
                        ushort address = (ushort)(variableInfo.Start + this.nudBoolAddress.Value);
                        bool value = this.cboBoolValue.SelectedIndex == 0;
                        this.modbusMaster.WriteSingleCoil(this.ComConfigModel.SlaveAddress, address, value);
                        this.MsgBox("写入成功！");
                    }
                    catch (Exception ex)
                    {
                        this.MsgBox(ex.Message);
                    }
                }
            }
        }

        private void btnUShortSetting_Click(object sender, EventArgs e)
        {
            if (this.modbusMaster != null)
            {
                VariableInfo variableInfo = this.cboUShort.SelectedItem as VariableInfo;
                if (variableInfo != null)
                {
                    try
                    {
                        ushort address = (ushort)(variableInfo.Start + this.nudUShortAddress.Value);
                        this.modbusMaster.WriteSingleRegister(this.ComConfigModel.SlaveAddress, address, (ushort)this.nudUShortValue.Value);
                        this.MsgBox("写入成功！");
                    }
                    catch (Exception ex)
                    {
                        this.MsgBox(ex.Message);
                    }
                }
            }
        }

        private void button_exportReport_Click(object sender, EventArgs e)
        {
            //创建1个工作簿，相当于1个Excel文件　　　　　　　　

            //Excel的文档结构是 Workbook->Worksheet（1个book可以包含多个sheet）
            Workbook workbook = new Workbook();

            //获取第一个sheet，进行操作，下标是从0开始
            Worksheet sheet = workbook.Worksheets[0];
            //当然你也可以自己添加1个命名的Worksheet到book中
            workbook.Worksheets.Add("测试sheet");

            //向A1单元格写入文字
            sheet.Range["A1"].Text = "测试序号";
            sheet.Range["B1"].Text = "体积";
            sheet.Range["C1"].Text = "压力";

            for (int n = 0; n < dataGridView1.Rows.Count - 1; n++)
            {
                for (int m = 0; m < dataGridView1.Columns.Count; m++)
                {
                    sheet.Range[n + 2, m + 1].Text = dataGridView1.Rows[n].Cells[m].Value.ToString();
                }
            }

            //将Excel文件保存到指定文件,还可以指定Excel版本
            workbook.SaveToFile("Sample.xls", ExcelVersion.Version97to2003);

            System.Diagnostics.Process.Start("Sample.xls");


        }

        private void button_random_Click(object sender, EventArgs e)
        {
            var r = new Random();

            int i = 0;
            foreach (var series in SeriesCollection)
            {
                int j = 0;
                foreach (var observable in series.Values.Cast<ObservableValue>())
                {
                    observable.Value = r.Next(0, 10);
                    //observable.Value = double.Parse(dataGridView1.Rows[j].Cells[i + 1].Value.ToString());
                    j++;
                }
                i++;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (SeriesCollection != null)
                {
                    var r = new Random();

                    int i = 0;
                    foreach (var series in SeriesCollection)
                    {
                        int j = 0;
                        foreach (var observable in series.Values.Cast<ObservableValue>())
                        {
                            //observable.Value = r.Next(0, 10);
                            observable.Value = double.Parse(dataGridView1.Rows[j].Cells[i + 1].Value.ToString());
                            j++;
                        }
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
