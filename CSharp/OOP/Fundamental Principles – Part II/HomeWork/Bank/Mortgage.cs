using System;

namespace HomeWork.Bank
{
    public class Mortgage : BankAccounts
    {
        private readonly int corporateClientMonths = 12;
        private readonly int privateClientMonths = 6;

        public Mortgage(decimal balance, int months, decimal interest, ClientType clientType)
            : base()
        {
            this.Months = months;
            this.Balance = balance + CalculateInterest(months, interest, balance, clientType);
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
                    return ((months * monthIntereset) / 100) * balance;
                }
            }
            else if (currentClient == ClientType.Corporate)
            {
                if (months > 12)
                {
                    decimal totalInterest = (corporateClientMonths * monthIntereset / 100);
                    totalInterest += (((months - corporateClientMonths) * monthIntereset) / 100);
                    this.Interest = totalInterest;
                    return this.Interest * balance;
                }
                else
                {
                    decimal totalInterest = (months * monthIntereset / 100);
                    this.Interest = totalInterest;
                    return this.Interest * balance;
                }
            }
            throw new ArgumentException();
        }
    }
}