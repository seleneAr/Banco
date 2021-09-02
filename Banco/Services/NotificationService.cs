using Banco.Interfaces;
using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Services
{
    class NotificationService : INotificable
    {
        public void sendEmail(EmailMessageModel message)
        {
            Console.WriteLine("Email " + message.Address + " Asunto: " + message.Subject + " Texto: " + message.Body);
        }

        public void sendSMS(SMSMessageModel message) {
            Console.WriteLine("SMS: Titulo: "+ message.Title + " Mensaje: "+ message.Message);
        }
    }
}
