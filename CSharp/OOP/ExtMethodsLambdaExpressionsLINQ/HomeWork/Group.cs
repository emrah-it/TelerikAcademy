namespace HomeWork
{
    public class Group
    {
        public int GroupNumber { get; set; }

        public string DepartmentName { get; set; }

        public string GroupName { get; set; }

        public Group(int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        public Group(int groupNumber, string departmentName, string groupName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
            this.GroupName = groupName;
        }
    }
}