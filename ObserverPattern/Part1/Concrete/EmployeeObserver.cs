using ObserverPattern.Part1.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Part1.Concrete
{
    public class EmployeeObserver : BaseObserver
    {
        public override void Update() => Console.WriteLine("Message to Employee:Product was changed..!");
       
    }
}
