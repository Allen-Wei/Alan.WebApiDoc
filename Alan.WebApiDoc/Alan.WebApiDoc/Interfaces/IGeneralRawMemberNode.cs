using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Alan.WebApiDoc.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alan.WebApiDoc.Models;

namespace Alan.WebApiDoc.Interfaces
{
    public interface IGeneralRawMemberNode
    {
        String GetXmlMemberName();

        //private String _originalName;

        //[XRawMember("name")]
        //public String OriginalName
        //{
        //    get { return this._originalName; }
        //    set
        //    {
        //        if (String.IsNullOrWhiteSpace(value)) return;
        //        /*TODO
        //         * String value = "M:Alan.WebApiDoc.Demonstration.Api.GenericParameterDemonstrationController.Put(Alan.WebApiDoc.Demonstration.Api.GenericParameterDemonstrationController.GenericParameter{Alan.WebApiDoc.Demonstration.Models.Person})";
        //         * Regex.IsMatch(value, @"^\w:([\w_]+\.?)+(\(([\w_]\.,?)*\))?$") //timeout
        //         */
        //        this._originalName = value;
        //    }
        //}
      
    }
}
