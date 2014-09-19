using System;
using System.Collections.Generic;
using System.Text;

namespace UnicornClicker
{
    public class Game
    {
        public Guid GameId { get; set; }
        public DateTime Played { get; set; }
        public int Duration { get; set; }
        public int Clicks { get; set; }
        public double ClicksPerSecond { get; set; }
    }
}
