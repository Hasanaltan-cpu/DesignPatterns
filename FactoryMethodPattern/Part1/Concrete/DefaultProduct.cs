using FactoryMethodPattern.Part1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Part1.Concrete
{
    public class DefaultProduct : IProduct

    {
        public string ShipFrom()
        {
            return "not avaliable";
        }
    }
}
