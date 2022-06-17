using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using TestBot.Bowling;
using TestBot.Match;

namespace TestBot.Matrix
{
    public class BowlingMatirx : IBowlingMatirx
    {
        private readonly ILogger _logger;

        private static BallModel lastBowledBall;

        public BowlingMatirx(ILogger<BowlingMatirx> logger)
        {
            _logger = logger;
        }

        static Dictionary<BallModel, MatchProgressModel> bowlingHistory = new Dictionary<BallModel, MatchProgressModel>();
        public BallModel getNextBall(MatchProgressModel progressModel)
        {
            try
            {

                if (progressModel?.iswicketlost == true || progressModel?.runonlastball == 0)
                {
                    if (lastBowledBall != null)
                    {
                        return lastBowledBall;
                    }
                }

                var nextBall = new BallModel();
                bool avaoidBall = false;

                do
                {
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

                    if (nextBall.bowingType == BowlingType.Bouncer && nextBall.speed >= 140)
                    {
                        nextBall.zone = BallPitchZone.zone1;
                    }
                    if (bowlingHistory.Values != null)
                    {
                        avaoidBall = bowlingHistory.Any(x => x.Key.bowlerType == nextBall.bowlerType && x.Key.bowingType == nextBall.bowingType && x.Key.zone == nextBall.zone
                                                        && (x.Key.speed >= nextBall.speed - 5 || x.Key.speed <= nextBall.speed + 5) && x.Value.runonlastball >= 4);
                    }
                } while (avaoidBall);

                if (String.IsNullOrEmpty(nextBall.bowlerName))
                {
                    _logger.LogCritical($"Next Ball object is not having values {JsonConvert.SerializeObject(nextBall)}");

                    nextBall = lastBowledBall;
                }

                bowlingHistory.Add(nextBall, null);

                lastBowledBall = nextBall;

                return nextBall;
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Exception occured {ex.StackTrace} , {ex.Message}");

                if (lastBowledBall != null)
                {
                    return lastBowledBall;
                };

                return new BallModel() { bowingType = BowlingType.Googly, bowlerType = BowlerTypes.LB, bowlerName = "Rafael Nadal", speed = 110, zone = BallPitchZone.zone2 };
            }
        }

        public void SaveLastBalInfo(MatchProgressModel matchProgress)
        {
            if (bowlingHistory.Any())
                bowlingHistory[bowlingHistory.Keys.Last()] = matchProgress;
        }
    }
}
