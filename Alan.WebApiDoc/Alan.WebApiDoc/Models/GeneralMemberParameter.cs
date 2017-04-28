using System;
using Alan.WebApiDoc.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alan.WebApiDoc.Interfaces;

namespace Alan.WebApiDoc.Models
{
    public abstract class GeneralMemberParameter : IRawMemberParameterNode
    {
        [XRawMember("name")]
        public String Name { get; set; }

        public abstract String Value { get; set; }
    }
}
