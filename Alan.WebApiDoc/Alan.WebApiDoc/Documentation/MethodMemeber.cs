using Alan.WebApiDoc.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.Documentation
{
    public class MethodMemeber
    {
        public MethodMemeber(GeneralRawMember member)
        {

        }
        public String MethodName { get; set; }
        public List<ParameterMember> Parameters { get; set; }
    }
}
