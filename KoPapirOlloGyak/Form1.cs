using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoPapirOlloGyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeGame();

        }

        private void InitializeGame()
        {
            numSetRnds.Value = 4;
            rdbRandom.Checked = true;
            txtScoreBoard.Enabled = false;
        }
    }
    enum Hit { NoHit = -1, Stone, Paper, Scissors };
    public class Game
    {
        public int ScorePlayer { get; set; }
        public int ScoreComputer { get; set; }
        public int SetRounds { get; set; }
        public int PlayedRounds { get; set; }

        StratRandom strRnd;
        StratAll strAll;
        StratBeatLast strBeatLast;

        Game(int setRounds)
        {
            strRnd = new StratRandom();
            strAll = new StratAll();
            strBeatLast = new StratBeatLast();
            ScorePlayer = 0;
            ScoreComputer = 0;
            SetRounds = setRounds;
            PlayedRounds = 0;
        }

        public bool PlayerScores()
        {
            return true;
        }


    }

    


}
