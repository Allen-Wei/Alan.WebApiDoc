using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Alan.WebApiDoc.Models
{
    public class RawDocMembers
    {
        [XmlElement("member")]
        public List<RawMember> Members { get; set; }
    }
}
