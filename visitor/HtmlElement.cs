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
            throw new System.NotImplementedException();
        }
    }
}