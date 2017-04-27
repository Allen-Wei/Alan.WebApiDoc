using Alan.WebApiDoc.Attributes;
using Alan.WebApiDoc.Interfaces;
using Alan.WebApiDoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.Utils
{
    public static class ExtensionMethods
    {

        public static T Convert<T>(this XRawMemberNode node)
            where T : new()
        {
            var model = new T();
            var validProperty = from property in typeof(T).GetProperties()
                                let attribute = property.GetCustomAttributes(typeof(XRawMemberAttribute), true).FirstOrDefault() as XRawMemberAttribute
                                where attribute != null && property.CanWrite
                                select new { attribute, property };

            foreach (var pair in validProperty)
            {
                String key = pair.attribute.Name;
                String value;
                if (!node.Attributes.TryGetValue(key, out value))
                {
                    var childNode = node.ChildNodes.FirstOrDefault(child => child.TagName == key);
                    value = childNode?.Value;
                }
                if (value == null) continue;

                pair.property.SetValue(model, value, null);
            }

            return model;
        }


        public static T Convert<T, TPara>(this XRawMemberNode node)
            where T : IRawMemberNode<TPara>, new()
            where TPara : IRawMemberParameterNode, new()
        {
            var model = node.Convert<T>();

            var parameters = node.ChildNodes.Where(child => child.TagName == model.GetParameterTagName());
            if (parameters.Any())
                model.Parameters = parameters.Select(para =>
                {
                    var paraModel = para.Convert<TPara>();
                    paraModel.SetValue(para.Value);
                    return paraModel;
                }).ToList();

            return model;
        }

    }
}
