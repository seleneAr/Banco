using Banco.Models;
using Banco.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface ITransferable
    {
        bool transfer(ClientModel from, ClientModel to, decimal ammount, NotificationService notificationService);
    }
}
