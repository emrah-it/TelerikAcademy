namespace HTMLRenderer
{
    using System.Collections.Generic;
    using System.Text;

    public interface IElement
    {
        IEnumerable<IElement> ChildElements { get; }

        string Name { get; }

        string TextContent { get; set; }

        void AddElement(IElement element);

        void Render(StringBuilder output);

        string ToString();
    }
}