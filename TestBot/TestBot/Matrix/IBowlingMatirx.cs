using TestBot.Bowling;
using TestBot.Match;

namespace TestBot.Matrix
{
    public interface IBowlingMatirx
    {
        BallModel getNextBall(MatchProgressModel progressModel);
    }
}