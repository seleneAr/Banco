using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class EmailMessageModel
    {
        public string Address { get; set; }

        public string Body { get; set; }

        public string Subject { get; set; }

        public EmailMessageModel(string email, string subject, string body)
        {
            Address = email;
            Body = body;
            Subject = subject;
        }
    }
}
