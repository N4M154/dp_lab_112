using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class BankAccInfo
    {
        public string AccNum;
        public double Balance;
        public List<string> Transactions;

        public BankAccInfo(string accNum, double balance)
        {
            AccNum = accNum;
            Balance = balance;
            Transactions = new List<string>();
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Transactions.Add($"Added amount {amount}");
            
        }

        public void Withdrawal(double amount)
        {
            if(Balance>amount)
            {
                Transactions.Add($"Withdrawn amount: {amount}");
            }
            else
            {
                Transactions.Add("Insufficient Balance!");
            }
        }

        public double getBalance()
        {
            return Balance;
        }

        public void seeTransactionHistory()
        {
            foreach (var transaction in Transactions)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}
