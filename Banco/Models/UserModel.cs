using Banco.Interfaces;
using Banco.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class UserModel : IUserable
    {
        public string Name { get; set;}

        public string Email { get; set; }

        public ClientModel Client { get; set; } = null;

        public WorkerModel Worker { get; set; } = null;

        public UserModel(string name, string email, EmailService emailService, ClientModel client, WorkerModel worker) {
            Name = name;
            Email = email;
            Client = client;
            Worker = worker;
            this.Register(emailService);
        }


        public void Register(EmailService emailService)
        {
            var welcomeEmail = new NotificationModel(Email, "Bienvenido al banco, esta es tu cuenta de usuario");
            emailService.send(welcomeEmail);
           
        }
    }
}
