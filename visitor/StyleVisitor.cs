using System.Text;

namespace visitor
{
    public class StyleVisitor : IVisitor
    {
        public void Visit(HtmlElement element)
        {
            StringBuilder sb = new StringBuilder(element.StartTag);

            sb.Insert(sb.Length - 1, " style = 'width:46px;' ");
            element.StartTag = sb.ToString();

          
        }

        public void Visit(HtmlParentElement parentElement)
        {
            StringBuilder sb = new StringBuilder(parentElement.StartTag);
            sb.Insert(sb.Length - 1, " style = 'width:58px;' ");
            parentElement.StartTag = sb.ToString();

            foreach (HtmlElement element in parentElement.GetChildren())
            {
                Visit(element);
            }
           
        }
    }
}