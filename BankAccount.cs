using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHomework
{
    public delegate void WithdrawEventHandler(string accountNumber, decimal balance, decimal amount, bool success);

    public class BankAccount
    {
        public event WithdrawEventHandler OnBankAccountChanged;

        public decimal Balance { get; set; }

        public string IBAN { get; set; }

        public BankAccount(string accountNumber, decimal defaultAmount)
        {
            this.IBAN = accountNumber;

            this.Balance = defaultAmount;
        }

        public void Withdraw(decimal amount)
        {
            bool success = false;

            if (this.Balance >= amount)
            {
                this.Balance = this.Balance - amount;

                success = true;
            }

            if (this.OnBankAccountChanged != null)
            {
                this.OnBankAccountChanged(this.IBAN, this.Balance, amount, success);
            }
        }
    }
}
