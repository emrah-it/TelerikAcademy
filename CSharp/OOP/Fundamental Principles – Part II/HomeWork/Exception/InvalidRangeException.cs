namespace HomeWork.Exception
{
    public class InvalidRangeException<T> : System.Exception
    {
        public InvalidRangeException(string msg, T start, T end)
            : base(msg)
        {
            this.Start = start;
            this.End = end;
        }

        public T End { get; set; }

        public T Start { get; set; }
    }
}