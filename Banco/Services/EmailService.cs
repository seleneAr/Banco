﻿using Banco.Interfaces;
using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Services
{
    class EmailService : INotificable
    {
        public void send(NotificationModel notification)
        {
            Console.WriteLine($"Email: {notification.Title}. Mensaje: {notification.Message} ");

        }
    }
}
