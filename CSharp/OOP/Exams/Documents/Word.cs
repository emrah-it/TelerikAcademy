using System;

namespace DocumentSystem
{
    public class Word : OfficeDocument, IEncryptable, IEditable
    {
        public int NumberOfCharacters { get; set; }

        public bool IsEncrypted
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Encrypt()
        {
            throw new NotImplementedException();
        }

        public void Decrypt()
        {
            throw new NotImplementedException();
        }

        public void ChangeContent(string newContent)
        {
            throw new NotImplementedException();
        }
    }
}