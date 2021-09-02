using Banco.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class WorkerModel
    {
        public string Name { get; set; }

        public string checkInterest(ClientModel client, InterestRateService interestRateService)
        {
            return interestRateService.CalculateInterestRate(client);
        }

    }
}
