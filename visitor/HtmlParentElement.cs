using System;
using System.Collections.Generic;

namespace visitor
{
    public class HtmlParentElement : HtmlTag
    {
        public HtmlParentElement(string tagName)
        {
            TagName = tagName;
            StartTag = "";
            EndTag = "";
        }
        protected List<HtmlTag> _children = new List<HtmlTag>();
        public override string TagName { get; set; }
        public override string StartTag { get; set; }
        public override string EndTag { get; set; }

        public override void AddChildTag(HtmlTag htmlTag)
        {
            _children.Add(htmlTag);
        }

        public override void RemoveChildTag(HtmlTag htmlTag)
        {
            _children.Remove(htmlTag);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void GenerateHtml()
        {
            Console.WriteLine(this.StartTag);


            int i = 0;
            foreach (HtmlTag tag in _children)
            {

                tag.GenerateHtml();
                i++;
            }

            Console.WriteLine(this.EndTag);
        }

        public override List<HtmlTag> GetChildren()
        {
            return _children;
        }
    }
}