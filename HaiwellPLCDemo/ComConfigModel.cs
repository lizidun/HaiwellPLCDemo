using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using System.Xml.XPath;

namespace HaiwellPLCDemo
{
    /// <summary>
    /// COM配置
    /// </summary>
    public class ComConfigModel
    {
        public string PortName { get; set; }
        public int BaudRate { get; set; }
        public Parity ComParity
        {
            get
            {
                switch (this.Parity)
                {
                    case "None":
                        return System.IO.Ports.Parity.None;
                    case "Odd":
                        return System.IO.Ports.Parity.Odd;
                    case "Even":
                        return System.IO.Ports.Parity.Even;
                    default:
                        return System.IO.Ports.Parity.None;
                }
            }
        }
        public string Parity { get; set; }
        public int DataBits { get; set; }
        public StopBits ComStopBits
        {
            get
            {
                switch (this.StopBits)
                {
                    case 1:
                        return System.IO.Ports.StopBits.One;
                    case 2:
                        return System.IO.Ports.StopBits.Two;
                    default:
                        return System.IO.Ports.StopBits.Two;
                }
            }
        }
        public int StopBits { get; set; }
        public byte SlaveAddress { get; set; }
        public SerialPort OpenSerialPort()
        {
            SerialPort sp = new SerialPort();
            sp.PortName = this.PortName;
            sp.BaudRate = this.BaudRate;
            sp.StopBits = this.ComStopBits;
            sp.Parity = this.ComParity;
            sp.DataBits = this.DataBits;
            sp.ReadTimeout = 1000;
            sp.WriteTimeout = 1000;
            sp.Open();
            return sp;
        }
        /// <summary>
        /// 获取保存的设置
        /// </summary>
        /// <returns></returns>
        public static ComConfigModel GetConfigModel()
        {
            XDocument doc = XDocument.Load(VariableInfo.FileName);
            XElement group = doc.XPathSelectElement(".//*[local-name()='Group' and @name='ComParam']");
            ComConfigModel comConfigModel = new ComConfigModel();
            if (group != null)
            {
                foreach(XElement xParam in group.Nodes())
                {
                    string name = xParam.GetAttr<string>("name");
                    switch (name)
                    {
                        case "ComDevNumber":
                            comConfigModel.SlaveAddress = xParam.GetAttr<byte>("value");
                            break;
                        case "ComBaudrate":
                            comConfigModel.BaudRate = xParam.GetAttr<int>("value");
                            break;
                        case "ComDatabits":
                            comConfigModel.DataBits = xParam.GetAttr<int>("value");
                            break;
                        case "ComParity":
                            comConfigModel.Parity = xParam.GetAttr<string>("value");
                            break;
                        case "ComStopbits":
                            comConfigModel.StopBits = xParam.GetAttr<int>("value");
                            break;
                        case "ComPort":
                            comConfigModel.PortName = xParam.GetAttr<string>("value");
                            break;
                    }
                }
            }
            return comConfigModel;
        }
        /// <summary>
        /// 保存当前设置
        /// </summary>
        public void SaveConfig()
        {
            XDocument doc = XDocument.Load(VariableInfo.FileName);
            XElement group = doc.XPathSelectElement(".//*[local-name()='Group' and @name='ComParam']");
            ComConfigModel comConfigModel = this;
            if (group != null)
            {
                foreach (XElement xParam in group.Nodes())
                {
                    string name = xParam.GetAttr<string>("name");
                    switch (name)
                    {
                        case "ComDevNumber":
                            xParam.SetAttr("value", comConfigModel.SlaveAddress);
                            break;
                        case "ComBaudrate":
                            xParam.SetAttr("value", comConfigModel.BaudRate);
                            break;
                        case "ComDatabits":
                            xParam.SetAttr("value", comConfigModel.DataBits);
                            break;
                        case "ComParity":
                            xParam.SetAttr("value", comConfigModel.Parity);
                            break;
                        case "ComStopbits":
                            xParam.SetAttr("value", comConfigModel.StopBits);
                            break;
                        case "ComPort":
                            xParam.SetAttr("value", comConfigModel.PortName);
                            break;
                    }
                }
            }
            doc.Save(VariableInfo.FileName);
        }
    }
}
