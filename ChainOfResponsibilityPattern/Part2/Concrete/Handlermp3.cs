﻿using ChainOfResponsibilityPattern.Part2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Part2.Concrete
{
    public class Handlermp3 : PlayerHandler
    {
        public override void Player(string filePath)
        {
            if (filePath.EndsWith(".mp3"))
            {
                Console.WriteLine("{0} dosyası oynatılıyor..! (mp3 player)", filePath);

            }
            else
            {
                if (_nextHandler !=null)
                {
                    _nextHandler.Player(filePath);
                }
            }
            ;
        }
    }
}
