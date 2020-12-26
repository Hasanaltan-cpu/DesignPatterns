using ObserverPattern.Part1.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Part1.EventManager
{
   public class ProductManager
    {
        List<BaseObserver> _observers;
        public ProductManager() => _observers = new List<BaseObserver>();
        public void UpdatePrice()
        {
            Console.WriteLine("Product price changed..!");
           Notification();
        }
        public void Notification()
        {
            foreach (var item in _observers)
            {
                item.Update();
            }
        }

        public void Attached(BaseObserver baseObserver) => _observers.Add(baseObserver);
        public void Detached(BaseObserver baseObserver) => _observers.Remove(baseObserver);
    }
}
