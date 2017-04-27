using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.Interfaces
{
    public interface IRawMemberNode<TParameter>
        where TParameter : IRawMemberParameterNode, new()
    {
        String GetParameterTagName();
        List<TParameter> Parameters { get; set; }
    }
}
