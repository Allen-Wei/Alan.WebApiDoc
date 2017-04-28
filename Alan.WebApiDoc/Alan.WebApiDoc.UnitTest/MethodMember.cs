using Alan.WebApiDoc.Attributes;
using Alan.WebApiDoc.Models;
using Alan.WebApiDoc.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.UnitTest
{
    public class MethodMember : GeneralRawMember
    {
        public List<PropertyMember> Properties { get; set; }
    }
}
