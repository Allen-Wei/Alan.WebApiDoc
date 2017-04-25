using System;
using Alan.WebApiDoc.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alan.WebApiDoc.Models;
using Alan.WebApiDoc.Library;

namespace Alan.WebApiDoc.UnitTest
{
    public class Member : RawMemberNode<Parameter>
    {
        [XRawMember("name")]
        public String Name { get; set; }

        public List<Parameter> Parameters { get; set; }

        [XRawMember("summary")]
        public String Summary { get; set; }
    }
}
