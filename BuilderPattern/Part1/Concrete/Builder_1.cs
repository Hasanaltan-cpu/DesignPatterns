using BuilderPattern.Part1.Delegate;
using BuilderPattern.Part1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Part1.Concrete
{
    public class Builder_1 : IBuilder
    {
        private Product product = new Product();
        public void ChickenBurger()
        {
           product.Add("Tavuk");
        }

        public void Hamburger()
        {
           product.Add("Et");
        }

        public Product GetProduct()
        {
            return product;
        }
    }
}
