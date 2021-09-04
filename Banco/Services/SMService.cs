using Banco.Interfaces;
using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Services
{
    class SMService : INotificable
    {
        public void send(NotificationModel notification)
        {
            Console.WriteLine($"SMS:  {notification.Title}. Mensaje: {notification.Message} ");

        }
    }
}
