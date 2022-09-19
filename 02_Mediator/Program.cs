using System;

namespace _02_Mediator
{
    internal class Program
    {
        //MediatR
        static void Main(string[] args)
        {
            Numerator vip = new VIPNumerator();
            Console.WriteLine(vip.CreateNumber("88888"));
            Console.WriteLine(vip.CreateNumber("55555"));
            //Console.WriteLine(vip.CreateNumber("lefhcnkenc"));

            Cashier cashier1 = new Cashier(vip) { Name = "Fermat" };
            Console.WriteLine(cashier1.CallCustomer());
            Console.WriteLine(cashier1.CallCustomer());

            Numerator normal = new NormalNumerator();


            Console.ReadKey();
        }
    }
}