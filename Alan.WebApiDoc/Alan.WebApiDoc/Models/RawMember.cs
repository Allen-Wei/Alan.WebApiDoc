using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Alan.WebApiDoc.Models
{
    public class RawMember
    {
        [XmlAttribute("name")]
        public String Name { get; set; }

        [XmlElement("summary")]
        public String Summary { get; set; }

        [XmlElement("returns")]
        public String Returns { get; set; }

        public String Remarks { get; set; }
    }
}
