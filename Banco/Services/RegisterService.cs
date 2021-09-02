using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Services
{
    class RegisterService
    {

        public ClientModel register(string name, string email,  decimal account )
        {
            var newClient = new ClientModel(name, email, account);

            var welcomeEmail = new EmailMessageModel(email, "Bienvenido al banco", "Esta es tu cuenta de usuario");

            var notificationService = new NotificationService();
            notificationService.sendEmail(welcomeEmail);

            return newClient;

        }
    }
}
