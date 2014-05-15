using System;

namespace DocumentSystem
{
    public class Excel : OfficeDocument, IEncryptable
    {
        public int Rows { get; private set; }

        public int Col { get; private set; }

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
    }
}