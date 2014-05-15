namespace HomeWork.First
{
    using System;
    using System.Collections.Generic;
    public class Classes : IComment
    {
        private string uniqueTextIdentifire;
        private List<Teachers> teachers  = new List<Teachers>();
        private string optionalComments;
        public List<Teachers> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }
        public string UniqueTextIdentifire
        {
            get
            {
                return this.uniqueTextIdentifire;
            }
            set
            {
                this.uniqueTextIdentifire = value;
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
        public Classes()
        {
           
        }
    }
}
