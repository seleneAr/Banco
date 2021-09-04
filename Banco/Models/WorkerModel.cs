using Banco.Interfaces;
using Banco.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class WorkerModel: IWorkable
    {
        public string WorkerID { get; set; }

     
        public string checkInterest(ClientModel client, InterestRateService interestRateService)
        {
            return interestRateService.CalculateInterestRate(client);
        }

        public WorkerModel()
        {
            WorkerID = Guid.NewGuid().ToString().Substring(0,5);
        }

    }
}
