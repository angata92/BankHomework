using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHomework
{
    public class Person
    {
        public string PersonalNumber { get; set; }

        public string FullName { get; set; }

        public List<BankAccount> Accounts { get; set; }

        public GSM Phone { get; set; }

        public Person(string personalNumber, string fullName, GSM phone)
        {
            this.PersonalNumber = personalNumber;

            this.FullName = fullName;

            this.Accounts = new List<BankAccount>();

            this.Phone = phone;
        }

        public void AddBankAccount(BankAccount bankAccount)
        {
            this.Accounts.Add(bankAccount);

            bankAccount.OnBankAccountChanged += Account_OnBankAccountChanged;
        }

        private void Account_OnBankAccountChanged(string accountNumber, decimal balance, decimal amount, bool success)
        {
            string message = string.Format("Name: {0}, IBAN: {1}, Success: {2}, Balance: {3}, Amount: {4}", this.FullName, accountNumber, success, balance, amount);

            Console.WriteLine(message);
        }
    }
}
