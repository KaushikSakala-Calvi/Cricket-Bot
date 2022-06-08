using System;
using System.Linq;
using TestBot.Bowling;

namespace TestBot.Matrix
{
    public class BowlingMatirx : IBowlingMatirx
    {
        public BallModel getNextBall()
        {
            var nextBall = new BallModel();
            string[] playerNames = Helper.DataHelper.GetPlayers().Where(x => x.CanBowl).Select(x => x.Name).ToArray();
            Random playerNameRandom = new Random();
            int playerIndex = playerNameRandom.Next(playerNames.Length);
            nextBall.bowlerName = playerNames[playerIndex];


            ///To Get Random Bowler Type
            Array bowlerTypeValues = Enum.GetValues(typeof(BowlerTypes));
            Random randomBowlerType = new Random();
            BowlerTypes bowlerType = (BowlerTypes)bowlerTypeValues.GetValue(randomBowlerType.Next(bowlerTypeValues.Length));

            nextBall.bowlerType = bowlerType;

            ///To Get Random Bowling Type
            Array bowlingTypeValues;
            Random randomBowlingType = new Random();
            if (nextBall.bowlerType.ToString().StartsWith("RA"))

            {
                bowlingTypeValues = Enum.GetValues(typeof(BowlingType));
                nextBall.bowingType = (BowlingType)bowlingTypeValues.GetValue(randomBowlingType.Next(bowlingTypeValues.Length - 3));
            }
            else
            {
                bowlingTypeValues = Enum.GetValues(typeof(BowlingType));
                nextBall.bowingType = (BowlingType)bowlingTypeValues.GetValue(randomBowlingType.Next(bowlingTypeValues.Length - 3, bowlingTypeValues.Length));
            }

            //Select Speed of the Ball
            int minSpeed = 0;
            int maxSpeed = 0;
            switch (nextBall.bowlerType)
            {
                case BowlerTypes.RAF:
                    minSpeed = (int)Speedlimit.RAF_MIN;
                    maxSpeed = (int)Speedlimit.RAF_MAX;
                    break;
                case BowlerTypes.RAFM:
                    minSpeed = (int)Speedlimit.RAFM_MIN;
                    maxSpeed = (int)Speedlimit.RAFM_MAX;
                    break;
                case BowlerTypes.RAS:
                    minSpeed = (int)Speedlimit.RAS_MIN;
                    maxSpeed = (int)Speedlimit.RAS_MAX;
                    break;
                case BowlerTypes.OB:
                    minSpeed = (int)Speedlimit.OB_MIN;
                    maxSpeed = (int)Speedlimit.OB_MAX;
                    break;
                case BowlerTypes.LB:
                    minSpeed = (int)Speedlimit.LB_MIN;
                    maxSpeed = (int)Speedlimit.LB_MAX;
                    break;
            }
            Random speedRandom = new Random();
            if (maxSpeed != 0 && minSpeed != 0)
            {
                nextBall.speed = speedRandom.Next(minSpeed, maxSpeed);
            }
            nextBall.zone = BallPitchZone.zone2;

            return nextBall;
        }
    }
}
