﻿using Alan.WebApiDoc.Interfaces;
using Alan.WebApiDoc.Attributes;
using Alan.WebApiDoc.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.Models
{
    public sealed class GeneralRawMemberNode : IGeneralRawMemberNode
    {
        private RawMemberNode node;
        private GeneralRawMemberNode(RawMemberNode node)
        {
            this.node = node;
        }
        public T ToModel<T>()
            where T: new()
        {
            return this.node.ToModel<T>();
        }
        public static GeneralRawMemberNode Init(RawMemberNode node)
        {
            var model = new GeneralRawMemberNode(node);
            return node.ToModel<GeneralRawMemberNode>(model);
        }

        [RawMember("name")]
        public String Name { get; set; }

        public string GetXmlMemberName()
        {
            return this.Name;
        }
        public RawMemberNode GetRawNode()
        {
            return this.node;
        }
    }
}
