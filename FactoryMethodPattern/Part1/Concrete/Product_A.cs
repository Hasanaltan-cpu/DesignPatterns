using FactoryMethodPattern.Part1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Part1.Concrete
{
    public class Product_A : IProduct
    {
        public string ShipFrom()
        {
           return "South Africa";
        }
    }
}
