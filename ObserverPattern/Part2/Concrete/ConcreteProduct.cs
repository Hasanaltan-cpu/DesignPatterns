using ObserverPattern.Part2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Part2.Concrete
{
    public class ConcreteProduct:Product
    {
        public ConcreteProduct(string productName,decimal unitPrice):base(productName,unitPrice)
        {

        }
    }
}
