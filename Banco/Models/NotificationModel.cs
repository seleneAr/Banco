using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class NotificationModel
    {
        public string Title { get; set; }

        public string Message { get; set; }


        public NotificationModel(string title, string message)
        {
            Title = title;
            Message = message;

        }
    }
}
