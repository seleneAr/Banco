using Banco.Models;
using Banco.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface IRegistrable
    {
        public ClientModel register(string name, string email, decimal account, NotificationService notificationService);
    }
}
