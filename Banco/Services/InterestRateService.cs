using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Services
{
    class InterestRateService
    {
        // de 0 a 100000 un 5%, de 10000 a 150000 un 3% de 15000 a 300000 un 2% ,as de 30000 un 1%

        public string CalculateInterestRate(ClientModel client)
        {
            var ammount = client.Account;
           if(ammount < 10000)
            {
                return "5%";
            }else if(ammount >= 10000 && ammount < 20000)
            {
                return "3%";
            }
            else
            {
                return "2%";
            }
        }
    }
}
