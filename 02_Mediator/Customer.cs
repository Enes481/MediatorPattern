using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Mediator
{
    internal class Customer : Colleague
    {
        public Customer(Numerator numerator) : base(numerator)
        {
        }

        public string Name { get; set; }
        public string TCKN { get; set; }

        public string TakeNumber()
        {
            int no = _numerator.CreateNumber(TCKN);
            return $"{Name} isimli müşterinin numarası : {no}";
        }
    }
}
