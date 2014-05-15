namespace HomeWork.Bank
{
    using System;
    using System.Text;

    public abstract class BankAccounts
    {
        private decimal balance;
        private string id;
        private decimal interest;
        private int months;
        public BankAccounts()
        {
            this.id = new Random().Next(100000, 1000000000).ToString();
        }

        public BankAccounts(decimal balance, int months, decimal interest)
        {
            this.Months = months;
            this.Interest = interest;
            this.Balance = balance;
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.balance = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            protected set
            {
                this.id = value;
            }
        }
        public decimal Interest
        {
            get
            {
                return this.interest;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.interest = value;
            }
        }

        public int Months
        {
            get
            {
                return this.months;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.months = value;
            }
        }

        public abstract decimal CalculateInterest(int months, decimal monthIntereset, decimal balance, ClientType currentClient);

        public virtual void DepositeMoney(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Deposit have to be positive");
            }
            if (this.Balance - value < 0)
            {
                throw new ArgumentException("Value is too much");
            }

            this.Balance -= value;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(this.id);
            result.AppendLine(this.Balance.ToString());
            return result.ToString();
        }
    }
}