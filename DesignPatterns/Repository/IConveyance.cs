using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IConveyance
    {
       
            void Start();
            void Stop();
            void TurnRight();
            void TurnLeft();
       
    }
}
