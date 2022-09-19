using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Mediator
{
    internal class VIPNumerator : Numerator
    {
        static int number = 500;
        List<string> tcknList = new List<string>() { "55555","88888" };

        public override int CreateNumber(string tckn)
        {
            if (tcknList.Contains(tckn))
            {
                Customer customer = new Customer(this) { Name = "Stanley", TCKN = tckn };
                customers.Enqueue(customer);
                return number++;
            }
            else
            {
                throw new Exception($"{tckn} VIP müşteriye ait bir TCKN değildir");
            }
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
