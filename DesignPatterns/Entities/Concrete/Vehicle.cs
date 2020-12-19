using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Entities.Concrete
{
    class Vehicle
    {
        IConveyance _conveyance;
        public Vehicle(IConveyance convenyance)
        {
            _conveyance = convenyance;
        }

        public void UseCar()
        {
            _conveyance.Start();
            _conveyance.TurnRight();
            _conveyance.Stop();
            _conveyance.TurnLeft();

        }
    }
}
