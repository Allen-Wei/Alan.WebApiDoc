using System;
using System.Text.RegularExpressions;
using Alan.WebApiDoc.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alan.WebApiDoc.Interfaces;
using Alan.WebApiDoc.Utils;

namespace Alan.WebApiDoc.Models
{
    public abstract class GeneralMember<TParameter> : GeneralRawMember, IRawMemberNode<TParameter>
        where TParameter : GeneralMemberParameter, new()
    {

        [XRawMember("returns")]
        public String Returns { get; set; }
        [XRawMember("example")]
        public String Example { get; set; }


        public abstract List<TParameter> Parameters { get; set; }

        public virtual string GetParameterTagName()
        {
            return "param";
        }
    }
}
