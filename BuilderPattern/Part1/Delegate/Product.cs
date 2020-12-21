using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Part1.Delegate
{
    public class Product
    {
        List<string> parts = new List<string>();
        public void Add(string part)
        {
            parts.Add(part);

        }

        public void Display()
        {
            Console.WriteLine("\nProduct Parts");

            foreach (var  item in parts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
         
        }

    }


}
