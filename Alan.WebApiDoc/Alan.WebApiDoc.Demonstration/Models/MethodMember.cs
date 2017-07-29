using Alan.WebApiDoc.Attributes;
using Alan.WebApiDoc.Interfaces;
using Alan.WebApiDoc.Models;
using Alan.WebApiDoc.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.Demonstration.Models
{
    public class MethodMember<TParameter> : IRawMethodMemberNode<TParameter>
        where TParameter : new()
    {
        [XRawMember("returns-fail")]
        public String Fails { get; set; }

        public string FullMethodName { get; set; }

        public string HttpMethod { get; set; }

        public string Url { get; set; }
        [XRawMember("author")]
        public String Author { get; set; }
        public List<TParameter> ParameterMembers { get; set; }

        [XRawMember("name")]
        public String Name { private get; set; }

        public string GetXmlMemberName()
        {
            return this.Name;
        }

        public string GetParameterTagName()
        {
            return "param";
        }
    }
}
