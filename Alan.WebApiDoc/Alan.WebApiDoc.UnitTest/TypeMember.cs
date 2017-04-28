using System;
using Alan.WebApiDoc.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alan.WebApiDoc.Models;
using Alan.WebApiDoc.Utils;

namespace Alan.WebApiDoc.UnitTest
{
    public class TypeMember : GeneralRawMember
    {
        public List<MethodMember> Methods { get; set; }
    }
}
