using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.Attributes
{
    public class XRawMemberAttribute:Attribute
    {
        public String Name { get; set; }
        public XRawMemberAttribute(string name)
        {
            this.Name = name;
        }
    }
}
