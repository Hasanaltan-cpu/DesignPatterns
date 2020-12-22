using BuilderPattern.Part1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Part1.Directories
{
    public class Directory
    {
        //It is not the same Constructor & OOP' Constructor Don't be confused.
        public void Constructor(IBuilder builder)
        {
            builder.ChickenBurger();
            builder.Hamburger();
        }
    }
}
