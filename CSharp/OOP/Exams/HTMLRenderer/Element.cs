namespace HTMLRenderer
{
    using System.Collections.Generic;
    using System.Text;

    public class Element : IElement
    {
        private IList<IElement> childElements;
        private string name;
        private string textContext;

        public Element(string name, string textContext)
            : this(name)
        {
            this.TextContent = textContext;
        }

        public Element(string name)
        {
            this.Name = name;
            this.childElements = new List<IElement>();
        }

        public IEnumerable<IElement> ChildElements
        {
            get
            {
                return this.childElements;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public virtual string TextContent
        {
            get
            {
                return this.textContext;
            }

            set
            {
                this.textContext = value;
            }
        }

        public virtual void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (!string.IsNullOrEmpty(this.Name))
            {
                output.AppendFormat("<{0}>", this.Name);
            }

            if (!string.IsNullOrEmpty(this.TextContent))
            {
                for (int i = 0; i < this.TextContent.Length; i++)
                {
                    char symbol = this.TextContent[i];
                    switch (symbol)
                    {
                        case '<':
                            output.Append("&lt;");
                            break;

                        case '>':
                            output.Append("&gt;");
                            break;

                        case '&':
                            output.Append("&amp;");
                            break;

                        default:
                            output.Append(symbol);
                            break;
                    }
                }
            }

            foreach (var item in this.ChildElements)
            {
                output.AppendFormat(item.ToString());
            }

            if (!string.IsNullOrEmpty(this.Name))
            {
                output.AppendFormat("</{0}>", this.Name);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            this.Render(output);

            return output.ToString();
        }
    }
}