using Banco.Models;
using Banco.Services;
using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var transferService = new TransferService();
            var emailService = new EmailService();
            var smsService = new SMService();
            var interestRateService = new InterestRateService();

            UserModel User1 = new UserModel("Juana", "juana@gmail.com", emailService, null, null);
            
            UserModel Client1 = new UserModel("Luisa", "luisa@gmail.com", emailService, new ClientModel(10000), null);

            UserModel Worker = new UserModel("Juan", "juan@gmail.com", emailService, null, new WorkerModel());

            UserModel ClientWorker = new UserModel("Rebeca", "rebeca@gmail.com", emailService, new ClientModel(500000), new WorkerModel());


            Client1.Client.transfer(ClientWorker.Client, 300, transferService, smsService);
            Console.WriteLine(ClientWorker.Worker.checkInterest(Client1.Client, interestRateService));

          
            
        }
    }
}
