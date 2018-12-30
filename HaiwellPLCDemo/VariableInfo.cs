using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;

namespace HaiwellPLCDemo
{
    /// <summary>
    /// 变量信息
    /// </summary>
    public class VariableInfo
    {
        public int Id { get; set; }
        public ushort Start { get; set; }
        public ushort End { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public bool IsBool { get; set; }
        public bool AllowWrite { get; set; } = true;
        public static string FileName => "Haiwell.PLC.dev";
        public override string ToString()
        {
            return $"{this.Name} {this.Text}";
        }
        public static List<VariableInfo> GetVariableInfos()
        {
            List<VariableInfo> lst = new List<VariableInfo>();
            if (File.Exists(FileName))
            {
                XDocument doc = XDocument.Load(FileName);
                XElement AddressInfo = doc.XPathSelectElement(".//*[local-name()='AddressInfo']");
                if(AddressInfo != null)
                {
                    foreach(XElement item in AddressInfo.Nodes())
                    {
                        string localName = item.Name.LocalName;
                        VariableInfo variableInfo = new VariableInfo();
                        lst.Add(variableInfo);
                        variableInfo.Start = item.GetAttr<ushort>("start");
                        variableInfo.End = item.GetAttr<ushort>("end");
                        variableInfo.Name = item.GetAttr<string>("name");
                        variableInfo.Text = item.GetAttr<string>("text");
                        if (localName.Contains("Bit"))
                        {
                            variableInfo.IsBool = true;
                        }
                        if (localName.Contains("Input"))
                        {
                            variableInfo.AllowWrite = false;
                        }
                    }
                }
            }
            return lst;
        }
    }
}
