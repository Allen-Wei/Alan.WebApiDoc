using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Alan.WebApiDoc.Models
{
    [XmlRoot("doc")]
    public class RawDocument
    {
        [XmlElement("members")]
        public RawDocMembers Members { get; set; }

        public static RawDocument Parse(String xmlPath)
        {
            XmlSerializer serialize = new XmlSerializer(typeof(RawDocument));
            var models = new RawDocument();
            using (TextReader reader = new StreamReader(xmlPath))
            {
                models = (RawDocument)serialize.Deserialize(reader);
            }
            return models;
        }
    }
}
