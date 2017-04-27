using System;
using Alan.WebApiDoc.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alan.WebApiDoc.Models;
using Alan.WebApiDoc.Interfaces;

namespace Alan.WebApiDoc.UnitTest
{
    public class Member : GeneralMember<Parameter>
    {

        public override List<Parameter> Parameters { get; set; }

    }
}
