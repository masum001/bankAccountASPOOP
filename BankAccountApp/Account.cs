using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAccountApp
{
    [Serializable]
    public class Account
    {
        public string AccountNumber { get; set; } 
        
        public string CustomerName { get; set; }

        public double Balance { get; private set; }

        public Account( string accountNumber, string customerName):this()
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
        }

        public Account()
        {
            Balance = 0;
        }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposit Successful";
        }

        public string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdraw Successful";
        }

        public string Report() => "hello "+CustomerName + " your current balance is "+ Balance+ " Taka";
    }
}