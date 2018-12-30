using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Windows.Forms;

namespace HaiwellPLCDemo
{
    public static class StExtend
    {
        public static void MsgBox(this Control @this, string msg)
        {
            MessageBox.Show(@this, msg);
        }
        public static T GetAttr<T>(this XElement @this, string attrName, T defaultvalue = default(T))
        {
            XAttribute xattr = @this.Attribute(attrName);
            if(xattr != null)
            {
                return (T)Convert.ChangeType(xattr.Value, typeof(T));
            }
            return defaultvalue;
        }
        public static void SetAttr(this XElement @this, string attrName, object value)
        {
            XAttribute xattr = @this.Attribute(attrName);
            if(xattr == null)
            {
                xattr = new XAttribute(XName.Get(attrName, @this.Name.NamespaceName), null);
                @this.Add(xattr);
            }
            xattr.Value = value.ToString();
        }
    }
}
