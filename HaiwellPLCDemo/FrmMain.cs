using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus.Data;
using System.IO.Ports;

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
        }
        private void LoadVariableInfo()
        {
            List<VariableInfo> lst = VariableInfo.GetVariableInfos();
            foreach(VariableInfo variableInfo in lst)
            {
                if (variableInfo.IsBool)
                {
                    this.cboBool.Items.Add(variableInfo);
                    if(variableInfo.Name == "Y")
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
                    if(variableInfo.Name == "V")
                    {
                        this.cboUShort.SelectedItem = variableInfo;
                    }
                }
            }
        }

        private void btnComSetting_Click(object sender, EventArgs e)
        {
            FrmSerialPortConfig frmSerialPortConfig = new FrmSerialPortConfig();
            if(frmSerialPortConfig.ShowDialog(this) == DialogResult.OK)
            {
                if(this.modbusMaster != null)
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
            if(variableInfo != null)
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
            if(this.modbusMaster != null)
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
                    catch(Exception ex)
                    {
                        this.MsgBox(ex.Message);
                    }
                }
            }
        }

        private void btnUShortSetting_Click(object sender, EventArgs e)
        {
            if(this.modbusMaster != null)
            {
                VariableInfo variableInfo = this.cboUShort.SelectedItem as VariableInfo;
                if(variableInfo != null)
                {
                    try
                    {
                        ushort address = (ushort)(variableInfo.Start + this.nudUShortAddress.Value);
                        this.modbusMaster.WriteSingleRegister(this.ComConfigModel.SlaveAddress, address, (ushort)this.nudUShortValue.Value);
                        this.MsgBox("写入成功！");
                    }
                    catch(Exception ex)
                    {
                        this.MsgBox(ex.Message);
                    }
                }
            }
        }
    }
}
