using Banco.Models;
using Banco.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface IClientable
    {
        public bool transfer(ClientModel to, decimal ammount, TransferService transferService, NotificationService notificationService);
    }
}
