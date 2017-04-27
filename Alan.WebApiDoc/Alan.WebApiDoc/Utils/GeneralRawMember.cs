using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Alan.WebApiDoc.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alan.WebApiDoc.Interfaces;

namespace Alan.WebApiDoc.Utils
{
    public class GeneralRawMember
    {
        private String _originalName;

        [XRawMember("name")]
        public String OriginalName
        {
            get { return this._originalName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value)) return;
                /*TODO
                 * String value = "M:Alan.WebApiDoc.Demonstration.Api.GenericParameterDemonstrationController.Put(Alan.WebApiDoc.Demonstration.Api.GenericParameterDemonstrationController.GenericParameter{Alan.WebApiDoc.Demonstration.Models.Person})";
                 * Regex.IsMatch(value, @"^\w:([\w_]+\.?)+(\(([\w_]\.,?)*\))?$") //timeout
                 */
                this._originalName = value;
            }
        }
        public String FullName
        {
            get
            {
                if (String.IsNullOrWhiteSpace(this.OriginalName)) return null;
                if (Regex.IsMatch(this.OriginalName, @"^\w:"))
                {
                    var leftBrackedIndex = this.OriginalName.IndexOf("(");
                    if (leftBrackedIndex < 0) return this.OriginalName.Substring(2);
                    return this.OriginalName.Substring(2, leftBrackedIndex - 2);

                }
                return null;
            }
        }
        [XRawMember("summary")]
        public String Summary { get; set; }

        public bool IsMethod
        {
            get
            {
                if (String.IsNullOrWhiteSpace(this.OriginalName)) return false;
                return this.OriginalName[0] == 'M';
            }
        }
        public bool IsType
        {
            get
            {
                if (String.IsNullOrWhiteSpace(this.OriginalName)) return false;
                return this.OriginalName[0] == 'T';
            }
        }
        public bool IsParamter
        {
            get
            {

                if (String.IsNullOrWhiteSpace(this.OriginalName)) return false;
                return this.OriginalName[0] == 'P';
            }
        }

        public String FullTypeName
        {
            get
            {
                var fullName = this.FullName;
                if (String.IsNullOrWhiteSpace(fullName)) return null;
                if (this.IsType) return fullName;
                if (this.IsMethod || this.IsParamter)
                {
                    var parts = fullName.Split('.');
                    return String.Join(".", parts.Take(parts.Length - 1));
                }
                return null;
            }
        }

        public String[] ParamtersTypes
        {
            get
            {
                if (!this.IsMethod) return null;
                var leftBracketIndex = this.OriginalName.IndexOf("(");
                if (leftBracketIndex < 0) return new String[0];
                var paramters = this.OriginalName.Substring(leftBracketIndex + 1).TrimEnd(')');
                if (String.IsNullOrWhiteSpace(paramters)) return new String[0];
                return paramters.Split(',');
            }
        }
    }
}
