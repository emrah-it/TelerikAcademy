namespace HomeWork.MyEventHadnler
{
    using System;

    public class CustumEvent : EventArgs
    {
        public string Message { get; set; }

        public CustumEvent(string msg)
        {
            this.Message = msg;
        }
    }
}