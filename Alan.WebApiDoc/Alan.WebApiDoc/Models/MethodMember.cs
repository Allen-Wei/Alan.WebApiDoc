using Alan.WebApiDoc.Attributes;
using Alan.WebApiDoc.Interfaces;
using Alan.WebApiDoc.Models;
using Alan.WebApiDoc.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.Models
{
    public class MethodMember<TParameter> : IRawMethodMemberNode<TParameter>
        where TParameter : new()
    {

        public string FullMethodName { get; set; }

        public string HttpMethod { get; set; }

        public string Url { get; set; }

        /// <summary>
        /// 综述
        /// </summary>
        [RawMember("summary")]
        public String Summary { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [RawMember("author")]
        public String Author { get; set; }

        /// <summary>
        /// 返回值
        /// </summary>
        [RawMember("returns")]
        public String Returns { get; set; }

        public List<TParameter> ParameterMembers { get; set; }

        [RawMember("name")]
        public String Name { private get; set; }

        public string GetXmlMemberName()
        {
            return this.Name;
        }

        public virtual string GetParameterTagName()
        {
            return "param";
        }
    }
}
