using System;

namespace DocumentSystem
{
    public class PDF : Binary, IEncryptable
    {
        public uint NumberOfPages { get; set; }

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