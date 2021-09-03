using Banco.Interfaces;
using Banco.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class WorkerModel: IWorkable
    {
        public string Name { get; set; }

        public ClientModel Client { get; set;  }
        
        public string checkInterest(ClientModel client, InterestRateService interestRateService)
        {
            return interestRateService.CalculateInterestRate(client);
        }

        public WorkerModel(string name, ClientModel client)
        {
            Name = name;
            Client = client;
        }

    }
}
