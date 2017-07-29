using Alan.WebApiDoc.Attributes;
using Alan.WebApiDoc.Interfaces;
using Alan.WebApiDoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alan.WebApiDoc.Models
{
    public class ParameterMember : IGeneralRawMemberNode
    {

        [RawMember("name")]
        public String Name {  get; set; }
        [RawMember(RawMemberNode.NODE_VALUE_ATTRIBUTE_NAME)]
        public String Value { get; set; }

        public string GetXmlMemberName()
        {
            return this.Name;
        }
    }
}