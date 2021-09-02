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

            ClientModel client1 = registerService.register("Juan", "juan@gmail.com", 20000);
            ClientModel client2 = registerService.register("Ramon", "ramon@gmail.com", 8000);

            WorkerModel worker = new WorkerModel();

            client1.transfer(client2,100, transferService, notificationService);
            worker.checkInterest(client1, interestRateService);
        }
    }
}
