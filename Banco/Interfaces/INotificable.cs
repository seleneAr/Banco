using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface INotificable
    {
        void send(NotificationModel notification);
    }
}
