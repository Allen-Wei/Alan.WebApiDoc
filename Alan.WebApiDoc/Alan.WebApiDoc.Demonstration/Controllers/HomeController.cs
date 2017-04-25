using Alan.WebApiDoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Xml.Linq;

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
            var doc = RawDocument.Parse(xmlPath);
            //var xdoc = XElement.Parse(System.IO.File.ReadAllText(xmlPath));
            var xdoc = XRawMemberNode.Parse(xmlPath);

            return View();
        }
    }
}