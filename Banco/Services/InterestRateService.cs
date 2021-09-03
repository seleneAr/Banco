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
            var ammount = client.Account;
           if(ammount < 10000)
            {
                return "Interés de " + client.Name+ " : 5%";
            }else if(ammount >= 10000 && ammount < 20000)
            {
                return "Interés de " + client.Name + " : 3%";
            }
            else
            {
                return "Interés de " + client.Name + " : 2%";
            }
        }
    }
}
