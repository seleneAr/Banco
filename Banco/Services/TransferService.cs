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
        public bool transfer(ClientModel from, ClientModel to, decimal ammount, NotificationService notificationService)
        {

            if(ammount > from.Account)
            {
                return false;
            }

            from.Account -= ammount;
            to.Account += ammount;


            SMSMessageModel notificationSender = new SMSMessageModel("Transferencia enviada", "Transferencia enviada a " + to.Name + " con valor de " + ammount + " saldo actual: "+ from.Account);
            SMSMessageModel notificationReceiver = new SMSMessageModel("Transferencia recibida", "Transferencia recibida de " + from.Name + " con valor de " + ammount + " saldo actual: " + to.Account);
            
            notificationService.sendSMS(notificationSender);
            notificationService.sendSMS(notificationReceiver);


            return true;
        }
    }
}
