using Banco.Interfaces;
using Banco.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class WorkerModel: IWorkable
    {
        public string WorkerID { get; set; }

        /// <summary>
        /// Trabajador con numero de identificacion. 
        /// </summary>
        public WorkerModel()
        {
            WorkerID = Guid.NewGuid().ToString().Substring(0,5);
        }

        /// <summary>
        /// Un trabajador puede calcular la tasa de interes de un cliente
        /// </summary>
        /// <param name="client">Cliente a calcular la tasa de interes</param>
        /// <param name="interestRateService">Servicio que realiza el calculo</param>
        /// <returns></returns>
        public string checkInterest(ClientModel client, InterestRateService interestRateService)
        {
            return interestRateService.CalculateInterestRate(client);
        }

       

    }
}
