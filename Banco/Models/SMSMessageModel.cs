using Banco.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class SMSMessageModel
    {
        public string Title { get; set; }
        public string Message { get; set; }

        public SMSMessageModel(string title, string message)
        {
            Title = title;
            Message = message;
        }
    }
}
