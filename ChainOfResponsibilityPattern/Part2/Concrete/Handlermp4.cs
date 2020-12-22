using ChainOfResponsibilityPattern.Part2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Part2.Concrete
{
    public class Handlermp4 : PlayerHandler
    {
        public override void Player(string filePath)
        {
            if (filePath.EndsWith(".mp4"))
            {
                Console.WriteLine("{0} dosyası oynatılıyor..!(mp4 player)", filePath);
            }
            else
            {
                if (_nextHandler !=null)
                {
                    _nextHandler.Player(filePath);
                }
            }
        }
    }
}
