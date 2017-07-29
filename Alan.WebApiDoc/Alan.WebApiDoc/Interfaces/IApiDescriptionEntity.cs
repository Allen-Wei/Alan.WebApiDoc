using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.Interfaces
{
    public interface IApiDescriptionEntity
    {
        String HttpMethod { get; set; }
        String Url { get; set; }
        String FullMethodName { get; set; }
    }
}
