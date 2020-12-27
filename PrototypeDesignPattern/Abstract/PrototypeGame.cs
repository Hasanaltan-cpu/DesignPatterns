using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.Abstract
{
    public abstract class PrototypeGame
    {
        public abstract PrototypeGame Clone();
    }
}
