using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentSystem
{
    public abstract class Document : IDocument
    {
        private string name;
        public Document()
        {
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cant be null");
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cant be only with white spaces");
                }

                this.name = value;

            }

        }

        public string Content { get; private set; }

        private const string NameInput = "name";

        private const string ContentInput = "content";

        public void LoadProperty(string key, string value)
        {
            if (NameInput == key)
            {
                this.Name = value;
            }
            else if (ContentInput == key)
            {
                this.Content = value;
            }
        }

        public void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>(this.Name, this.Content));
        }
    }
}