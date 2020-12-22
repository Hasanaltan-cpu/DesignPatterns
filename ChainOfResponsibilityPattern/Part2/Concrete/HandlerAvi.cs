using ChainOfResponsibilityPattern.Part2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Part2.Concrete
{
    public class HandlerAvi : PlayerHandler
    {
        public override void Player(string filePath)
        {
            if (filePath.EndsWith(".avi"))
            {
                Console.WriteLine("{0} dosyası oynatılıyor..! (avi player)", filePath);
            }
            else
            {
                Console.WriteLine("{0} geçersiz dosya formatı..!", filePath);
            }
        }
    }
}
