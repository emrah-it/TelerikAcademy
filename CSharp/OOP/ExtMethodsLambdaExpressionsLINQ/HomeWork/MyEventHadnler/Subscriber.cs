namespace HomeWork.MyEventHadnler
{
    using System;

    public class Subscriber
    {
        public Subscriber(string someText, Publisher current)
        {
            this.SomeText = someText;
            current.myEvents += PrintSomeEvet;
        }

        public string SomeText { get; set; }

        public void PrintSomeEvet(object e, CustumEvent evn)
        {
            Console.WriteLine(this.SomeText + " " + evn.Message);
        }
    }
}