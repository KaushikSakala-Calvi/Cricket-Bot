using System;
using TestBot.Batting;
using TestBot.Bowling;
using TestBot.Fielding;

namespace TestBot.Model
{
    public class BowlingConfig
    {

        public BallPitchZone zone { get; set; }
        public BowlingType bowlingType { get; set; }
        public BowlerTypes bowlerType { get; set; }

        public int speed { get; set; }

        public string bowlerName { get; set; }
        
    }

}
