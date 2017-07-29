using Alan.WebApiDoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.Interfaces
{
    public interface IRawMethodMemberNode<TParameter>: IApiDescriptionEntity, IGeneralRawMemberNode
        where TParameter: new()
    {
        String GetParameterTagName();
        List<TParameter> ParameterMembers { set; }
    }
}
