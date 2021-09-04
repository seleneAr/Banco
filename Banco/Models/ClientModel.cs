using Banco.Interfaces;
using Banco.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class ClientModel : IClientable
    {
        
       public BankAccountModel Account { get; set; }

        public ClientModel(decimal account)
        {
            Account = new BankAccountModel(account);
        }


        public bool transfer(ClientModel to, decimal ammount, TransferService transferService, SMService smsService)
        {
           
            return transferService.transfer(this, to, ammount, smsService);
        }
    }
}
