using System;
using Newtonsoft.Json;
using System.Linq;
using Alan.WebApiDoc.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alan.WebApiDoc.Utils;

namespace Alan.WebApiDoc.UnitTest
{
    [TestClass]
    public class XRawNodeTest
    {
        [TestMethod]
        public void ReadTest()
        {
            //var doc1 = XRawMemberNode.Parse(@"C:\Users\Alan\Workspace\Projects\Alan.WebApiDoc\Alan.WebApiDoc\Alan.WebApiDoc.Demonstration\App_Data\Alan.WebApiDoc.Demonstration.XML").ToList();
            var doc1 = XRawMemberNode.Parse(@"C:\Users\Alan\Workspace\Projects\WebApiDoc\Alan.WebApiDoc.Demonstration\App_Data\WebApiDoc.XML").ToList();
            //var doc2 = XRawMemberNode.Parse(@"D:\OpenSource\Alan.WebApiDoc\Alan.WebApiDoc\Alan.WebApiDoc.Demonstration\App_Data\Alan.WebApiDoc.Demonstration.XML");
            var result = doc1.Select(d => d.Convert<Member, Parameter>()).ToList();
            System.IO.File.WriteAllText(@"D:\doc.json", JsonConvert.SerializeObject(result, Formatting.Indented));
        }
    }
}
