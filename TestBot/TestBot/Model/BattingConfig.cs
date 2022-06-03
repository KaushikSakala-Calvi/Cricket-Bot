using TestBot.Bowling;

namespace TestBot.Batting
{
    public class BattingConfig
    {
        public int Id { get; set; }
        public BowlingType BowlingType { get; set; }
        public BowlerTypes BowlerType { get; set; }
        public int MinBowlSpeed { get; set; }
        public int MaxBowlSpeed { get; set; }
        public BallPitchZone BowlingZone { get; set; }
        public Shots SelectedShot { get; set; }
    }
}
