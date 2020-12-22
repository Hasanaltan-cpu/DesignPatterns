using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Part2.Abstract
{
    public abstract class PlayerHandler
    {
        protected PlayerHandler _nextHandler;

        public PlayerHandler nextHandler { set => _nextHandler = value; }

        public abstract void Player(string filePath);
    }
}
