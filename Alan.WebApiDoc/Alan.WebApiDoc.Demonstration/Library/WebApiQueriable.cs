using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Alan.WebApiDoc.Models;
using System.Web.Http;
using Alan.WebApiDoc.Interfaces;
using Alan.WebApiDoc.Demonstration.Models;

namespace Alan.WebApiDoc.Demonstration.Library
{
    public class WebApiQueriable : IApiQueryable
    {
        public List<IApiDescriptionEntity> GetApis()
        {
            var q = from api in System.Web.Http.GlobalConfiguration.Configuration.Services.GetApiExplorer().ApiDescriptions
                    select new MethodMember<ParameterMember>()
                    {
                        HttpMethod = api.HttpMethod.ToString(),
                        Url = api.RelativePath,
                        FullMethodName = $"{api.ActionDescriptor.ControllerDescriptor.ControllerType}.{api.ActionDescriptor.ActionName}"
                    };

            return q.Select(m => m as IApiDescriptionEntity).ToList();
        }
    }
}