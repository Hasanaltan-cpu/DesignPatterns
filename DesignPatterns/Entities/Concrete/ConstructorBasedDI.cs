using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Entities.Concrete
{
    class ConstructorBasedDI
    {
        static void Main(string[] argm)
        {
      
             
           
                Vehicle vehicleCar = new Vehicle(new Car());
                vehicleCar.UseCar();
                //or
                Vehicle vehicleBus = new Vehicle(new Bus());
                vehicleBus.UseCar();
                //veya
                Vehicle vehicleMotorBike = new Vehicle(new MotorBike());
                vehicleMotorBike.UseCar();
          
        }
    }
   
}
