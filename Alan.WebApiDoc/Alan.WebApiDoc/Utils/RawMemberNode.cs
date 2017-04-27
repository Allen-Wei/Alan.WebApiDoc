using Alan.WebApiDoc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.Utils
{
    public abstract class RawMemberNode<TParameter> : IRawMemberNode<TParameter>
        where TParameter : IRawMemberParameterNode, new()
    {
        public List<TParameter> Parameters { get; set; }

        public abstract string GetParameterTagName();
    }
}
