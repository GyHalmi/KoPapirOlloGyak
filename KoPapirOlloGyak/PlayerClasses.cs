using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOlloGyak
{

    public class Player
    {
        public int Score { get; set; }
        public int Hit { get; set; }
    }
    
    public class ComputerPlayer : Player
    {
        StratRandom strRnd;
        StratAll strAll;
        StratBeatLast strBeatLast;
        public 

        ComputerPlayer()
        {
            strRnd = new StratRandom();
            strAll = new StratAll();
            strBeatLast = new StratBeatLast();
        }
        public void NewHit()
        {

        }
    }
}
