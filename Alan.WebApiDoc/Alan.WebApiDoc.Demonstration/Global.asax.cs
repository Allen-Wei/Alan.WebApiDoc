using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using Alan.WebApiDoc.Models;

namespace Alan.WebApiDoc.Demonstration
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var query = from api in System.Web.Http.GlobalConfiguration.Configuration.Services.GetApiExplorer().ApiDescriptions
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
            System.IO.File.WriteAllText(@"D:\api.json", JsonConvert.SerializeObject(query.ToList(), Formatting.Indented));
        }
    }
}