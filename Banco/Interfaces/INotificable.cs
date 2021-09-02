using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interfaces
{
    interface INotificable
    {
        void sendSMS(SMSMessageModel message);
        void sendEmail(EmailMessageModel message);
    }
}
