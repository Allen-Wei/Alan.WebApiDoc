using Alan.WebApiDoc.Attributes;
using Alan.WebApiDoc.Interfaces;
using Alan.WebApiDoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alan.WebApiDoc.Demonstration.Models
{
    public class CustomParameterMember : ParameterMember
    {
        [RawMember("is-required")]
        public bool IsRequired { get; set; }
    }
}