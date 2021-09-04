using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class BankAccountModel
    {
        public string Iban { get; set; }
        public decimal Value { get; set; } = 0;

        /// <summary>
        /// Creacion de la cuenta bancaria. El iban se crea con una identificacion unica aleatoria, se convierte a tipo string
        /// </summary>
        /// <param name="value">Dinero en la cuenta</param>
        public BankAccountModel(decimal value)
        {
            Iban = Guid.NewGuid().ToString();
            Value = value;
        }
    }
}
