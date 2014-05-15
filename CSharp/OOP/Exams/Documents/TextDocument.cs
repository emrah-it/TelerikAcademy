using System;

namespace DocumentSystem
{
    public class TextDocument : Document, IEditable
    {
        public char Charset { get; set; }

        public void ChangeContent(string newContent)
        {
            throw new NotImplementedException();
        }
    }
}