namespace HomeWork.Second
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                ValidateWorkHoursAndSalary(value);
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                ValidateWorkHoursAndSalary(value);
                this.workHoursPerDay = value;
            }
        }

        public Worker(double workHours, decimal weekSalary)
        {
            this.WorkHoursPerDay = workHours;
            this.WeekSalary = weekSalary;
        }

        public decimal MoneyPerHours()
        {
            decimal result = this.WeekSalary / (decimal)(this.WorkHoursPerDay * 5);
            return result;
        }
        private void ValidateWorkHoursAndSalary<T>(T value)
        {
            dynamic curr = value;
            if (curr < 0)
            {
                throw new ArgumentException("Cant be negative");
            }
        }
    }
}
