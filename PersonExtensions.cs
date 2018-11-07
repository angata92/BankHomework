using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHomework
{
    public static class PersonExtensions
    {
        public static decimal CheckBankAccount(this Person person, string bankAccountNumber)
        {
            foreach (var account in person.Accounts)
            {
                if (account.IBAN == bankAccountNumber)
                {
                    return account.Balance;
                }
            }

            return 0;
        }
    }
}
