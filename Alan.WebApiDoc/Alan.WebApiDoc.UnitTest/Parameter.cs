using Alan.WebApiDoc.Attributes;
using Alan.WebApiDoc.Interfaces;
using Alan.WebApiDoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.UnitTest
{
    public class Parameter : GeneralMemberParameter
    {
        public String Value { get; private set; }
        public override void SetValue(string nodeValue)
        {
            this.Value = nodeValue;
        }
    }
}
