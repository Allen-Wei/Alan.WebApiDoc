using Alan.WebApiDoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.Interfaces
{
    public interface IApiQueriable
    {
        List<ApiDescriptionEntity> GetApis();
    }
}
