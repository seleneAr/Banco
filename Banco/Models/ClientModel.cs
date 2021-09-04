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

        /// <summary>
        /// Al crear un nuevo cliente, se crea una cuenta bancaria de cliente
        /// </summary>
        /// <param name="account">Cantidad de dinero al crear la cuenta</param>
        public ClientModel(decimal account)
        {
            Account = new BankAccountModel(account);
        }

        /// <summary>
        /// Un cliente puede realizar transferencias a otro.
        /// </summary>
        /// <param name="to">Cliente que realiza la transferencia</param>
        /// <param name="ammount">Cantidad de dinero a transferir</param>
        /// <param name="transferService">Servicio que realiza la transferencia</param>
        /// <param name="smsService">Servicio que envia mensaje de confirmacion</param>
        /// <returns></returns>
        public bool transfer(ClientModel to, decimal ammount, TransferService transferService, SMService smsService)
        {
           
            return transferService.transfer(this, to, ammount, smsService);
        }
    }
}
