using ObserverPattern.Part1.Concrete;
using ObserverPattern.Part1.EventManager;
using ObserverPattern.Part2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part1

            var customerObserver = new CustomerObserver();
            var employeeObserver = new EmployeeObserver();

            ProductManager productManager = new ProductManager();
            productManager.Attached(new EmployeeObserver());
            productManager.Attached(customerObserver);
            productManager.UpdatePrice();

            #endregion
            #region Part2
            ConcreteProduct concreteProduct = new ConcreteProduct("Boxing Gloves", 12.55M);
            concreteProduct.FollowList.Add(new ConcreteMember { Email = "hsnaltan13@gmail.com" });
            concreteProduct.FollowList.Add(new ConcreteMember { Email = "hsnaltan13@gmail.com" });
            concreteProduct.FollowList.Add(new ConcreteMember { Email = "hsnaltan13@gmail.com" });

            concreteProduct.Price = 8.99M;

            #endregion


            Console.ReadKey();
        }
    }
}
