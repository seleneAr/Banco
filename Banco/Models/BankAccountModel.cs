using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class BankAccountModel
    {
        public string Iban { get; set; }
        public decimal Value { get; set; } = 0;

        public BankAccountModel(decimal value)
        {
            Iban = Guid.NewGuid().ToString();
            Value = value;
        }
    }
}
