using PrototypeDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.Concretes
{
    public class Game :PrototypeGame
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameStyle { get; set; }
        public bool Status { get; set; }
        public Game (int GameId,string GameName,string GameStyle, bool Status)
        {
            this.GameId = GameId;
            this.GameName = GameName;
            this.GameStyle = GameStyle;
            this.Status = Status;
        }

        public override PrototypeGame Clone()
        {
            return this.MemberwiseClone() as PrototypeGame;
        }
    }
}
