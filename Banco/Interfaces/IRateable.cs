using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface IRateable
    {
        public string CalculateInterestRate(ClientModel client);
    }
}
