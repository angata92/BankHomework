using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHomework
{
    public class MobileCompany
    {
        private Person[] _clients;

        public MobileCompany(Person[] clients)
        {
            this._clients = clients;
        }

        public void MontlyCharge(string personNumber, string bankAccountNumber, decimal money)
        {
            foreach (var client in this._clients)
            {
                if (client.PersonalNumber == personNumber)
                {
                    foreach (var bankAccount in client.Accounts)
                    {
                        if (bankAccount.IBAN == bankAccountNumber)
                        {
                            bankAccount.Withdraw(money);
                        }
                    }
                }
            }
        }
    }
}
