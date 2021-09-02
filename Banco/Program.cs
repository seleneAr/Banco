using Banco.Models;
using Banco.Services;
using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            var registerService = new RegisterService();
            var transferService = new TransferService();
            var notificationService = new NotificationService();
            var interestRateService = new InterestRateService();

            ClientModel cliente1 = registerService.register("Juan", "juan@gmail.com", 20000);
            ClientModel cliente2 = registerService.register("Ramon", "ramon@gmail.com", 8000);

            WorkerModel trabajador = new WorkerModel();

            cliente1.transfer(cliente2,100, transferService, notificationService);
            trabajador.checkInterest(cliente1, interestRateService);
        }
    }
}
