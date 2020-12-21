using BuilderPattern.Part1.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Part1.Interface
{
    public interface IBuilder
    {
        void ChickenBurger();
        void Hamburger();
        

        Product GetProduct();
    }
}
