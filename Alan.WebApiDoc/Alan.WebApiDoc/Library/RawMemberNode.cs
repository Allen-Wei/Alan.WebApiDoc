using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.Library
{
    public abstract class RawMemberNode<TParameter> : IRawMemberNode<TParameter>
        where TParameter : new()
    {
        public List<TParameter> Parameters { get; set; }
    }
}
