using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Mediator
{
    abstract class Numerator
    {
        protected Queue<Customer> customers;

        public Numerator()
        {
            customers = new Queue<Customer>();
        }

        public abstract int CreateNumber(string tckn);
        public abstract Customer GetCustomer();
    }
}
