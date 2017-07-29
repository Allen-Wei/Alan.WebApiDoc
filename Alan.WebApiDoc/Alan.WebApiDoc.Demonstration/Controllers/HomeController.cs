using Alan.WebApiDoc.Models;
using System.Web.Http;
using Alan.WebApiDoc.Demonstration.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Xml.Linq;
using Alan.WebApiDoc.Demonstration.Models;

namespace Alan.WebApiDoc.Demonstration.Controllers
{
    /// <summary>
    /// Home controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Index action
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var xmlPath = HostingEnvironment.MapPath("~/App_Data/Alan.WebApiDoc.Demonstration.XML");
            WebApiQueriable query = new WebApiQueriable();
            List<TypeMember<MethodMember<CustomParameterMember>, CustomParameterMember>> typeMembers = 
                RawMemberNode.Parse<TypeMember<MethodMember<CustomParameterMember>, CustomParameterMember>, MethodMember<CustomParameterMember>, CustomParameterMember>(xmlPath, query);

            return Json(typeMembers, JsonRequestBehavior.AllowGet);
        }
    }
}