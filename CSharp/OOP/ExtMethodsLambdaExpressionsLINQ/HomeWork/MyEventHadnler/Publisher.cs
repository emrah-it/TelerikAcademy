namespace HomeWork.MyEventHadnler
{
    using System;

    public class Publisher
    {
        public event EventHandler<CustumEvent> myEvents;

        public void MakeSomething()
        {
            OnRiseEvents(new CustumEvent("HelloWorld"));
        }

        private void OnRiseEvents(CustumEvent custumEvent)
        {
            EventHandler<CustumEvent> current = myEvents;
            if (current != null)
            {
                custumEvent.Message += " ";
                custumEvent.Message += DateTime.Now.ToString();
                current(this, custumEvent);
            }
        }
    }
}