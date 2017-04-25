using Alan.WebApiDoc.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.UnitTest
{
    public class Parameter
    {

        [XRawMember("name")]
        public String Name { get; set; }

        [XRawMember("example")]
        public String Example { get; set; }
    }
}
