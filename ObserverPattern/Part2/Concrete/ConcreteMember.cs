using ObserverPattern.Part2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Part2.Concrete
{
    public class ConcreteMember : IMember
    {
        public string Email { get; set; }
        public void Update(Product product)
        {
            Console.WriteLine($"{product.ProductName} price {product.Price} has been changed.Notification  {Email} has been sent!"); 
        }
    }
}
