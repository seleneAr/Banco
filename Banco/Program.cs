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

            ClientModel client1 = registerService.register("Juan", "juan@gmail.com", 20000, notificationService);
            ClientModel client2 = registerService.register("Ramon", "ramon@gmail.com", 8000, notificationService);
    
            WorkerModel worker = new WorkerModel("Lucia",null);
            ClientModel workerClient = registerService.register("Rebeca", "rebeca@gmail.com", 50000, notificationService);
            WorkerModel worker2 = new WorkerModel("Rebeca", workerClient );



            client1.transfer(client2,100, transferService, notificationService);
           Console.WriteLine(worker.checkInterest(client1, interestRateService));
            worker2.Client.transfer(client1,500, transferService, notificationService);
        }
    }
}
