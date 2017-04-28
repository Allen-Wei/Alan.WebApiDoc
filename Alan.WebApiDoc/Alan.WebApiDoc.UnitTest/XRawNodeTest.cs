using System;
using Alan.WebApiDoc.Attributes;
using Newtonsoft.Json;
using System.Linq;
using Alan.WebApiDoc.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alan.WebApiDoc.Utils;
using System.Reflection;
using System.Diagnostics;

namespace Alan.WebApiDoc.UnitTest
{
    public interface Person
    {

        [XRawMember("FN")]
        String FirstName { get; set; }
    }
    public class Student : Person
    {
        public String FirstName { get; set; }
    }
    [TestClass]
    public class XRawNodeTest
    {
        [TestMethod]
        public void ReadTest()
        {
            //var doc1 = XRawMemberNode.Parse(@"C:\Users\Alan\Workspace\Projects\Alan.WebApiDoc\Alan.WebApiDoc\Alan.WebApiDoc.Demonstration\App_Data\Alan.WebApiDoc.Demonstration.XML").ToList();
            //var doc1 = XRawMemberNode.Parse(@"C:\Users\Alan\Workspace\Projects\WebApiDoc\Alan.WebApiDoc.Demonstration\App_Data\WebApiDoc.XML").ToList();

            var doc1 = XRawMemberNode.Parse(@"D:\OpenSource\Alan.WebApiDoc\Alan.WebApiDoc\Alan.WebApiDoc.Demonstration\App_Data\Alan.WebApiDoc.Demonstration.XML");
            var result = doc1.Select(d => d.Convert<TypeMember>()).ToList();
            var typeMembers = result.GetTypeMembers();
            foreach (var tm in typeMembers)
            {
                tm.Methods = tm.GetMethodMembers(result).ToList();
            }
            System.IO.File.WriteAllText(@"D:\doc.json", JsonConvert.SerializeObject(typeMembers, Formatting.Indented));
        }
    }
}
