using System;
using System.Text;

namespace HomeWork.Bank
{
    public class Loan : BankAccounts
    {
        private readonly int corporateClientMonths = 2;
        private readonly int privateClientMonths = 3;

        public Loan(decimal balance, int months, decimal interest, ClientType currentClient)
            : base()
        {
            this.Months = months;
            this.Balance = balance + CalculateInterest(months, interest, balance, currentClient);
        }

        public override decimal CalculateInterest(int months, decimal monthIntereset, decimal balance, ClientType currentClient)
        {
            if (currentClient == ClientType.Private)
            {
                if (months <= privateClientMonths)
                {
                    this.Interest = 0;
                    return 0;
                }
                else
                {
                    this.Interest = monthIntereset;
                    return (((months - privateClientMonths) * monthIntereset) / 100) * balance;
                }
            }
            else if (currentClient == ClientType.Corporate)
            {
                if (months < corporateClientMonths)
                {
                    this.Interest = 0;
                    return 0;
                }
                else
                {
                    decimal totalInterest = (((months - corporateClientMonths) * monthIntereset) / 100);
                    this.Interest = totalInterest;
                    return this.Interest * balance;
                }
            }
            throw new ArgumentException();
        }
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.AppendFormat("ID: {0}\n", this.Id);
            toString.AppendFormat("Balance : {0}", this.Balance);

            return toString.ToString();
        }
    }
}