using BuilderPattern.Part1.Delegate;
using BuilderPattern.Part1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Part1.Concrete
{
    public class Builder_2 : IBuilder
    {
        private Product product = new Product();
        public void ChickenBurger()
        {
            product.Add("Chicken");
            product.Add("Bread");
            product.Add("Mayoniesa");
        } 

        public void Hamburger()
        {
            product.Add("Meat");
            product.Add("Bread");
            product.Add("Onion");
        }

        public Product GetProduct()
        {
            return product;
        }
    }
}
