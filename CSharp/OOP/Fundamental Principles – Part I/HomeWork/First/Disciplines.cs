namespace HomeWork.First
{
    using System;
    class Disciplines: NameAttribute, IComment
    {
        private int numberOfLectures;
        private int numberOfExersises;
        private string optionalComments;

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExersises
        {
            get
            {
                return this.numberOfExersises;
            }
            set
            {
                this.numberOfExersises = value;
            }
        }

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
    }

}
