using Alan.WebApiDoc.Attributes;
using Alan.WebApiDoc.Models;
using System;
using System.Reflection;
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
                                let attribute = property.GetCustomAttributes<XRawMemberAttribute>(true).FirstOrDefault()
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

                if (node.Value != null && pair.property.Name == nameof(node.Value))
                    pair.property.SetValue(model, node.Value, null);
            }


            return model;
        }


        public static IEnumerable<T> GetTypeMembers<T>(this IEnumerable<T> members)
            where T : GeneralRawMember
        {
            return members.Where(m => m.IsType);
        }
        public static IEnumerable<TMethod> GetMethodMembers<TType, TMethod>(this TType typeMember, IEnumerable<TMethod> allMembers)
            where TType: GeneralRawMember
            where TMethod : GeneralRawMember
        {
            return allMembers.Where(m => m.IsMethod && m.FullTypeName == typeMember.FullTypeName);
        }

    }
}
