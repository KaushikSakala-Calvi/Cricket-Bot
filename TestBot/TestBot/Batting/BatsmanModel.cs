using TestBot.Fielding;

namespace TestBot.Batting
{
    public class BatsmanModel
    {
        public Shots shots { get; set; }
        public int batSpeed { get; set; }
        public string batsman { get; set; }
        public fieldPosition FieldPosition { get; set; }
    }
}
