using System;
using System.Collections.Generic;

namespace HomeWork.Bank
{
    public abstract class Customer
    {
        protected ClientType currentClient;

        public Customer()
        {
            this.Deposite = new List<Deposite>();
            this.Lonas = new List<Loan>();
            this.Mortgage = new List<Mortgage>();
        }

        protected List<Deposite> Deposite { get; set; }

        protected List<Loan> Lonas { get; set; }

        protected List<Mortgage> Mortgage { get; set; }
        public decimal AllDeposite()
        {
            decimal deposit = 0;
            foreach (var item in Deposite)
            {
                deposit += item.Balance;
            }
            return deposit;
        }

        public decimal AllLoans()
        {
            decimal loans = 0;
            foreach (var item in Lonas)
            {
                loans += item.Balance;
            }
            foreach (var item in Mortgage)
            {
                loans += item.Balance;
            }
            return loans;
        }

        public void MakeDepositeAcocunt(decimal deposite, int months, decimal interest)
        {
            this.Deposite.Add(new Deposite(deposite, months, interest, currentClient));
        }

        public void TakeLoan(decimal balance, int months, decimal interest)
        {
            Loan newLoan = new Loan(balance, months, interest, currentClient);
            this.Lonas.Add(newLoan);
        }

        public void TakeMortageLoan(decimal deposite, int months, decimal interest)
        {
            this.Mortgage.Add(new Mortgage(deposite, months, interest, currentClient));
        }

        public void MakeDepositeToLoanAccount()
        {
            foreach (var item in this.Lonas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Enter ID that you want to make deposite");
            string ID = Console.ReadLine();


            foreach (var item in this.Lonas)
            {
                if (item.Id == ID)
                {
                    Console.WriteLine("Enter balance to eneter");
                    item.DepositeMoney(decimal.Parse(Console.ReadLine()));
                    if (item.Balance == 0)
                    {
                        this.Lonas.Remove(item);
                    }
                    return;
                }
            }
            Console.WriteLine("Please Eneter Correct ID");
            return;
        }

        public void MakeDepositeToMortgageAccount()
        {
            foreach (var item in this.Mortgage)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Enter ID that you want to make deposite");
            string ID = Console.ReadLine();


            foreach (var item in this.Mortgage)
            {
                if (item.Id == ID)
                {
                    Console.WriteLine("Enter balance to eneter");
                    item.DepositeMoney(decimal.Parse(Console.ReadLine()));
                    if (item.Balance == 0)
                    {
                        this.Mortgage.Remove(item);
                    }
                    return;
                }
            }
            Console.WriteLine("Please Eneter Correct ID");
            return;
        }

        public void MakeDepositeToDepositeAccount()
        {
            foreach (var item in this.Deposite)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Enter ID that you want to make deposite");
            string ID = Console.ReadLine();


            foreach (var item in this.Deposite)
            {
                if (item.Id == ID)
                {
                    Console.WriteLine("Enter balance to eneter");
                    item.DepositeMoney(decimal.Parse(Console.ReadLine()));
                    
                    return;
                }
            }
            Console.WriteLine("Please Eneter Correct ID");
            return;
        }

        public void DrowMoneyFromDepositeAccount(decimal money)
        {
            foreach (var item in this.Deposite)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Enter ID that you want to make deposite");
            string ID = Console.ReadLine();


            foreach (var item in this.Deposite)
            {
                if (item.Id == ID)
                {
                    Console.WriteLine("Enter balance to eneter");
                    item.DrawMoney(decimal.Parse(Console.ReadLine()));

                    return;
                }
            }
            Console.WriteLine("Please Eneter Correct ID");
            return;
        }
        
    }
}