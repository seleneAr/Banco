using Banco.Models;
using Banco.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface IWorkable
    {
        public string checkInterest(ClientModel client, InterestRateService interestRateService);
    }
}
