using System;
using Alan.WebApiDoc.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alan.WebApiDoc.Models;
using Alan.WebApiDoc.Utils;
using Alan.WebApiDoc.Interfaces;

namespace Alan.WebApiDoc.Demonstration.Models
{
    public class TypeMember<TMethod, TParameter> : IGeneralRawMemberNode, IRawTypeMemberNode<TMethod, TParameter>
        where TMethod: IRawMethodMemberNode<TParameter>, new()
        where TParameter : new()
    {

        [XRawMember("summary")]
        public String Summary { get; set; }

        [XRawMember("name")]
        public String Name { private get; set; }

        public List<TMethod> MethodMembers
        {
            get; set;
        }

        public string GetXmlMemberName()
        {
            return this.Name;
        }
    }
}
