using System;
using System.Collections.Generic;

namespace visitor
{
    public class HtmlElement : HtmlTag
    {
        public HtmlElement(string tagName)
        {
            TagName = tagName;
            TagBody = "";
            StartTag = "";
            EndTag = "";
        }

        public override string TagName { get; set; }
        public override string StartTag { get; set; }
        public override string EndTag { get; set; }

        public override void GenerateHtml()
        {
           Console.Write(StartTag);
            Console.Write(TagBody);
            Console.Write(EndTag);
            Console.WriteLine();
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        public override List<HtmlTag> GetChildren()
        {
            HtmlTag ob = new HtmlElement(this.TagName);
            ob.StartTag = this.StartTag;
            ob.EndTag = this.EndTag;
            List<HtmlTag> ls = new List<HtmlTag>();
            ls.Add(ob);
            return ls;
        }
    }
}