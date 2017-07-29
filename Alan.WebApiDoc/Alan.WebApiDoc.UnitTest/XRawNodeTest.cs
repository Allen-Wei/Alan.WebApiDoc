using System;
using Alan.WebApiDoc.Attributes;
using Newtonsoft.Json;
using System.Linq;
using Alan.WebApiDoc.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alan.WebApiDoc.Utils;
using System.Reflection;
using System.Diagnostics;
using Alan.WebApiDoc.Demonstration.Library;

namespace Alan.WebApiDoc.UnitTest
{
    [TestClass]
    public class XRawNodeTest
    {
        [TestMethod]
        public void ReadTest()
        {
            var doc1 = RawMemberNode.Parse(@"C:\Users\Alan\Workspace\Projects\Alan.WebApiDoc\Alan.WebApiDoc\Alan.WebApiDoc.Demonstration\App_Data\Alan.WebApiDoc.Demonstration.XML").ToList();
            //var types = XRawMemberNode.Parse<TypeMember, MethodMember>(@"C:\Users\Alan\Workspace\Projects\Alan.WebApiDoc\Alan.WebApiDoc\Alan.WebApiDoc.Demonstration\App_Data\Alan.WebApiDoc.Demonstration.XML").ToList();
            //var doc1 = XRawMemberNode.Parse(@"C:\Users\Alan\Workspace\Projects\WebApiDoc\Alan.WebApiDoc.Demonstration\App_Data\WebApiDoc.XML").ToList();
            //var doc1 = XRawMemberNode.Parse(@"D:\OpenSource\Alan.WebApiDoc\Alan.WebApiDoc\Alan.WebApiDoc.Demonstration\App_Data\Alan.WebApiDoc.Demonstration.XML");

            System.IO.File.WriteAllText(@"D:\doc.json", JsonConvert.SerializeObject(doc1, Formatting.Indented));
        }
    }
}
