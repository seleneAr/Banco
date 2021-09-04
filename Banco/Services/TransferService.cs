using Banco.Interfaces;
using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Services
{
    class TransferService : ITransferable
    {
        /// <summary>
        /// Funcion que realiza una transferencia entre dos clientes
        /// </summary>
        /// <param name="from"> Cliente que realiza transferencia </param>
        /// <param name="to"> Cliente que recibe la transferencia </param>
        /// <param name="ammount"> Cantidad de la transferencia </param>
        /// <returns> Devuelve true/false en función si se ha podido realizar la transferencia </returns>
        public bool transfer(ClientModel from, ClientModel to, decimal ammount, SMService smsService)
        {

            if (ammount > from.Account.Value || ammount < 0)
            {
                return false;
            }

            from.Account.Value -= ammount;
            to.Account.Value += ammount;

            NotificationModel notificationSender = new NotificationModel($"Nº de cuenta {to.Account.Iban}", $"Transferencia enviada  con valor de  {ammount} saldo actual:  {from.Account.Value} ");
          
            NotificationModel notificationReceiver = new NotificationModel($"Nº de cuenta {from.Account.Iban}", $"Transferencia recibida con valor de { ammount} saldo actual:  { to.Account.Value}");
            
            smsService.send(notificationSender);
            smsService.send(notificationReceiver);


            return true;
        }
    }
}
