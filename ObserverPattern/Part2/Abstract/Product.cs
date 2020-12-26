using ObserverPattern.Part2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Part2.Abstract
{
   public abstract class Product
    {
        public string ProductName { get; set; }

        private decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                if (_price>value)
                {

                }
                _price = value;
            }
        }

       public  List<ConcreteMember> FollowList = new List<ConcreteMember>();
        private void Notification()
        {
            foreach  (IMember member in FollowList)
            {
                member.Update(this);
            }

        }

        public Product(string productName,decimal unitPrice)
        {
            this.ProductName = productName;
            this.Price = unitPrice;
        }

       
    }
}
