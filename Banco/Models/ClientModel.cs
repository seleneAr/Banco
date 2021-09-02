using Banco.Interfaces;
using Banco.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class ClientModel 
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Account { get; set; }


        public ClientModel(string name, string email, decimal account)
        {
            Name = name;
            Email = email;
            Account = account;
        }

        public bool transfer(ClientModel to, decimal ammount, TransferService transferService, NotificationService notificationService)
        {
            return transferService.transfer(this, to, ammount, notificationService);
        }
    }
}
