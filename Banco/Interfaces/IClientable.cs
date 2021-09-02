

using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface IClientable
    {
        bool Transfer(ClientModel to, decimal ammount);

    }
}
