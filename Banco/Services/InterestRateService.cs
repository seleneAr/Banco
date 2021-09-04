using Banco.Interfaces;
using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Services
{
    class InterestRateService : IRateable
    {
       
        public string CalculateInterestRate(ClientModel client)
        {
            var ammount = client.Account.Value;
            var iban = client.Account.Iban;
           if(ammount < 10000)
            {
                return "Interés de cuenta nº" + iban + " : 5%";
            }else if(ammount >= 10000 && ammount < 20000)
            {
                return "Interés de cuenta nº" + iban + " : 3%";
            }
            else
            {
                return "Interés de cuenta nº" + iban + " : 2%";
            }
        }
    }
}
