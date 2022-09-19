using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Mediator
{
    internal class NormalNumerator : Numerator
    {
        static int number = 100;

        public override int CreateNumber(string tckn)
        {
            Customer customer = new Customer(this) { Name = "Marty", TCKN = tckn };
            customers.Enqueue(customer);
            return number++;
        }

        public override Customer GetCustomer()
        {
            if (customers.Count > 0)
            {
                return customers.Dequeue();
            }

            return null;
        }
    }
}
