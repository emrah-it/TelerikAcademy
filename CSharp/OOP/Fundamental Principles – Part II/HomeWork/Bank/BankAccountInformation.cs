namespace HomeWork.Bank
{
    using System;
    public abstract class BankAccountInformation
    {
        private decimal balance;
        private decimal interestRate;

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            protected set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                this.interestRate = value;
            }
        }

        protected virtual decimal InterestCalculation(int months, decimal interest)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return (this.Balance / 100) * (decimal)interest * months;
            }
        }
        public virtual void Deposite(decimal deposite)
        {
            if (deposite < 0)
            {
                throw new ArgumentException("Deposite cant be negative");
            }
            this.Balance += deposite;
        }


    }
}
