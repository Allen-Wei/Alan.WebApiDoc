using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.Library
{
    public interface IRawMemberNode<TParameter>
        where TParameter : new()
    {
        List<TParameter> Parameters { get; set; }
    }
}
