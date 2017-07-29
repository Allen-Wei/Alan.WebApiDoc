using Alan.WebApiDoc.Attributes;
using Alan.WebApiDoc.Models;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Alan.WebApiDoc.Interfaces;

namespace Alan.WebApiDoc.Utils
{
    public static class ExtensionMethods
    {
        public static String GetFullName(this IGeneralRawMemberNode member)
        {
            if (String.IsNullOrWhiteSpace(member.GetXmlMemberName())) return null;
            if (Regex.IsMatch(member.GetXmlMemberName(), @"^\w:"))
            {
                var leftBrackedIndex = member.GetXmlMemberName().IndexOf("(");
                if (leftBrackedIndex < 0) return member.GetXmlMemberName().Substring(2);
                return member.GetXmlMemberName().Substring(2, leftBrackedIndex - 2);

            }
            return null;
        }

        public static bool IsMethod(this IGeneralRawMemberNode member)
        {
            if (String.IsNullOrWhiteSpace(member.GetXmlMemberName())) return false;
            return member.GetXmlMemberName()[0] == 'M';
        }
        public static bool IsType(this IGeneralRawMemberNode member)
        {
            if (String.IsNullOrWhiteSpace(member.GetXmlMemberName())) return false;
            return member.GetXmlMemberName()[0] == 'T';
        }
        public static bool IsProperty(this IGeneralRawMemberNode member)
        {
            if (String.IsNullOrWhiteSpace(member.GetXmlMemberName())) return false;
            return member.GetXmlMemberName()[0] == 'P';
        }

        public static String GetFullTypeName(this IGeneralRawMemberNode member)
        {
            var fullName = member.GetFullName();
            if (String.IsNullOrWhiteSpace(fullName)) return null;
            if (member.IsType()) return fullName;
            if (member.IsMethod() || member.IsProperty())
            {
                var parts = fullName.Split('.');
                return String.Join(".", parts.Take(parts.Length - 1));
            }
            return null;
        }

        public static String[] GetParamtersTypes(this IGeneralRawMemberNode member)
        {
            if (!member.IsMethod()) return null;
            var leftBracketIndex = member.GetXmlMemberName().IndexOf("(");
            if (leftBracketIndex < 0) return new String[0];
            var paramters = member.GetXmlMemberName().Substring(leftBracketIndex + 1).TrimEnd(')');
            if (String.IsNullOrWhiteSpace(paramters)) return new String[0];
            return paramters.Split(',');
        }
    }
}
