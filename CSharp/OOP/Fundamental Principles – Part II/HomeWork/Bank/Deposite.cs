namespace HomeWork.Bank
{
    using System;

    public class Deposite : BankAccounts
    {
        public Deposite(decimal balance, int months, decimal interest, ClientType currentClient)
            : base()
        {
            this.Months = months;
            this.Balance = balance + CalculateInterest(months, interest, balance, currentClient);
        }

        public override decimal CalculateInterest(int months, decimal monthIntereset, decimal balance, ClientType currentClient)
        {
            if (balance > 1000)
            {
                this.Interest = monthIntereset;
                return monthIntereset * balance;
            }
            else return 0;
        }

        public override void DepositeMoney(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Cant be negative deposit");
            }
            this.Balance += value;
        }

        public void DrawMoney(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Cant be negative draw money");
            }
            if (this.Balance - value < 0)
            {
                throw new ArgumentException("Not enough money");
            }
            this.Balance -= value;
        }
    }
}