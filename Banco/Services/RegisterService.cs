using Banco.Interfaces;
using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Services
{
    class RegisterService: IRegistrable
    {

        public ClientModel register(string name, string email,  decimal account, NotificationService notificationService )
        {
            var newClient = new ClientModel(name, email, account);

            var welcomeEmail = new EmailMessageModel(email, "Bienvenido al banco", "Esta es tu cuenta de usuario");

            notificationService.sendEmail(welcomeEmail);

            return newClient;

        }
    }
}
