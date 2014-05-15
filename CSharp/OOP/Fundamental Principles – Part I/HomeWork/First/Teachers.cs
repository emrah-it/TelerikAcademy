namespace HomeWork.First
{
    using System;
    public class Teachers : NameAttribute, IComment, IPeople
    {
        private string optionalComments;
        public string OptionalComments
        {
            get
            {
                return this.optionalComments;
            }
            set
            {
                this.optionalComments = value;
            }
        }

        public Teachers(string name)
        {
            this.Name = name;
        }
        public Teachers()
        {

        }
    }
}
