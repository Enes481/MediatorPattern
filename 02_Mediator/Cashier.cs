using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Mediator
{
    internal class Cashier : Colleague
    {
        public Cashier(Numerator numerator) : base(numerator)
        {
        }

        public string Name { get; set; }

        public string CallCustomer()
        {
            Customer customer = _numerator.GetCustomer();
            return $"{Name} adlı bankacı {customer.Name} isimli müşteriyle ilgileniyor";
        }
    }
}
