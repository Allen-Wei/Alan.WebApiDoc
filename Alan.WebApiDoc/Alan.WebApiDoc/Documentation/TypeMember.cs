using Alan.WebApiDoc.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.Documentation
{
    public class TypeMember<TMethod> : GeneralRawMember
        where TMethod : new()
    {
        private GeneralRawMember member;
        public List<TMethod> Methods { get; set; }
        public TypeMember(GeneralRawMember member)
        {
            this.member = member;
        }

    }
}
