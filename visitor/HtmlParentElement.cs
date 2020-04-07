namespace visitor
{
    public class HtmlParentElement : HtmlTag
    {
        public HtmlParentElement(string tagName)
        {
        }

        public override string TagName { get; set; }
        public override string StartTag { get; set; }
        public override string EndTag { get; set; }

        public override void AddChildTag(HtmlTag htmlTag)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveChildTag(HtmlTag htmlTag)
        {
            throw new System.NotImplementedException();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void GenerateHtml()
        {
            throw new System.NotImplementedException();
        }
    }
}