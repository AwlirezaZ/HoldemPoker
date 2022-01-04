using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Player
    {
        public string PlayerName { get; set; }
        public Player(string playerName)
        {
            PlayerName = playerName;
        }
    }
}
