using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Alan.WebApiDoc.Models;
using System.Web.Http;

namespace Alan.WebApiDoc.Demonstration.Library
{
    public class WebApiQueriable //: IApiQueriable
    {
        public List<object> GetApis()
        {
            var q = from api in System.Web.Http.GlobalConfiguration.Configuration.Services.GetApiExplorer().ApiDescriptions
                    select new
                    {
                        HttpMethod = api.HttpMethod.ToString(),
                        RelativePath = api.RelativePath,
                        ControllerName = api.ActionDescriptor.ControllerDescriptor.ControllerName,
                        ControllerType = api.ActionDescriptor.ControllerDescriptor.ControllerType.FullName,
                        ActionName = api.ActionDescriptor.ActionName,
                        Parameters = (from para in api.ParameterDescriptions ?? new System.Collections.ObjectModel.Collection<System.Web.Http.Description.ApiParameterDescription>()
                                      let paraDesc = para.ParameterDescriptor
                                      let paraType = (paraDesc == null) ? typeof(object) : paraDesc.ParameterType
                                      select new
                                      {
                                          Name = para.Name,
                                          Source = para.Source.ToString(),
                                          ParaType = paraType,
                                          TypeName = paraType.Name,
                                          TypeFullName = paraType.FullName
                                      }).ToList()
                    };
         
            return null;
        }
    }
}