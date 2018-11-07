using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHomework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person ivan = new Person("13579", "Ivan Ivanov", new GSM("0123456789"));

            ivan.AddBankAccount(new BankAccount("123", 1000));
            ivan.AddBankAccount(new BankAccount("321", 800));

            Person petya = new Person("97531","Petya Petrova", new GSM("9876543210"));

            petya.AddBankAccount(new BankAccount("098", 3000));
            petya.AddBankAccount(new BankAccount("890", 1800));

            MobileCompany mobileCompany = new MobileCompany(new Person[] { ivan, petya });

            mobileCompany.MontlyCharge("13579", "123", 150);

            Console.WriteLine();

            mobileCompany.MontlyCharge("13579", "321", 150);

            Console.WriteLine();

            mobileCompany.MontlyCharge("97531", "890", 150);

            Console.WriteLine("Check bank accounts.....................................");

            Console.WriteLine("Account 123: " + ivan.CheckBankAccount("123"));
            Console.WriteLine("Account 321: " + ivan.CheckBankAccount("321"));

            Console.WriteLine("Account 098: " + petya.CheckBankAccount("098"));
            Console.WriteLine("Account 890: " + petya.CheckBankAccount("890"));

            Console.ReadLine();
        }
    }
}
