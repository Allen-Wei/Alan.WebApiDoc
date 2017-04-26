using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Alan.WebApiDoc.Attributes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Alan.WebApiDoc.Models
{
    public class XRawMemberNode
    {
        public String TagName { get; private set; }
        private XRawMemberNode()
        {
            this.Attributes = new Dictionary<string, string>();
            this.ChildNodes = new List<XRawMemberNode>();
        }
        public IDictionary<String, String> Attributes { get; private set; }

        public IEnumerable<XRawMemberNode> ChildNodes { get; private set; }
        public String Value { get; set; }

        private static XRawMemberNode ToRawNode(XElement ele)
        {
            if (ele == null) return null;

            var node = new XRawMemberNode();
            if (ele.HasAttributes)
                node.Attributes = ele.Attributes().ToDictionary(att => att.Name.LocalName, att => att.Value);
            if (ele.HasElements)
                node.ChildNodes = ele.Elements().Select(child => ToRawNode(child));
            node.Value = ele.Value;
            node.TagName = ele.Name.LocalName;
            return node;
        }

        public static IEnumerable<XRawMemberNode> Parse(String xmlPath)
        {
            String xml = File.ReadAllText(xmlPath);
            var xele = XDocument.Parse(xml);
            var rootDoc = xele.Element("doc");
            var members = rootDoc.Element("members");
            IEnumerable<XElement> nodes = members.Elements("member");
            return nodes.Select(ToRawNode);
        }

    }
}
