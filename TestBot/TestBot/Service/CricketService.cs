using System.Linq;
using System.Collections.Generic;
using TestBot.Batting;
using TestBot.Bowling;
using TestBot.Fielding;
using TestBot.Helper;
using TestBot.Match;
using TestBot.Model;
using System;

namespace TestBot.Service
{
    public class CricketService : ICricketService
    {
        //private readonly CricketRepository _cricketRepo;//commented as of now
        //public CricketService(CricketRepository cricketRepo)
        //{
        //    _cricketRepo = cricketRepo;
        //}

        static Dictionary<HybridModel, MatchProgressModel> matchStats = new Dictionary<HybridModel, MatchProgressModel>();
        static List<FieldingModel> latestFieldSettings = new List<FieldingModel>();
        static List<Player> players = DataHelper.GetPlayers();
        public List<BattingConfig> GetAllBattingOptions()
        {
            var battingData = GetBattingOptions();//get static data from helper class
            return battingData;
        }

        public void SaveFieldSettings(List<FieldingModel> fieldingModels)
        {
            latestFieldSettings.Clear();
            latestFieldSettings.AddRange(fieldingModels);
        }
        //Implement code to select the correct batting output based on Input
        public BatsmanModel GetOptimizedBattingData(BallModel ballInfo)
        {
            //Drives shot should played according to the field setting, and zone
            //If the bowler speed ranges from 90 - 110 - we should increase the bat speed
            //get all static data 
            List<BattingConfig> battingOptions = GetBattingOptions();

            //caluclate the shot
            var batData = battingOptions
                                .Where(x => x.BowlerType == ballInfo.bowlerType
                                && x.BowlingType==ballInfo.bowingType
                                    && x.BowlingZone == ballInfo.zone
                                    && ballInfo.speed >= x.MinBowlSpeed
                                    &&  ballInfo.speed<=x.MaxBowlSpeed);

            if(!batData.Any())
            {
                batData = battingOptions.Where(x => x.BowlingType == ballInfo.bowingType);
            }

            BatsmanModel batsmanModel = GetBestPossibleShot(batData, ballInfo);

            matchStats.Add(new HybridModel() { BallModel = ballInfo, BatsmanModel = batsmanModel }, null);
            return batsmanModel;
        }

        public void SaveLastBalInfo(MatchProgressModel matchProgress)
        {
            if (matchStats.Any())
                matchStats[matchStats.Keys.Last()] = matchProgress;

            if (matchProgress.iswicketlost)
                players.OrderBy(x => x.Order).FirstOrDefault(x => !x.IsOut).IsOut = true;
        }

        private BatsmanModel GetBestPossibleShot(IEnumerable<BattingConfig> batData, BallModel ballInfo)
        {
            var shots = batData.Join(latestFieldSettings,
                                    bat => bat.SelectedShot,
                                    field => field.Prvshot,
                                    (bat, field) => new BatsmanModel() { shots = bat.SelectedShot, FieldPosition = field.fp }).Distinct().ToList();

            var prevShots = matchStats.Where(x => x.Key.BallModel.bowingType == ballInfo.bowingType
            && x.Value.runonlastball > 0
            && !x.Value.iswicketlost).OrderByDescending(y=>y.Value.runonlastball)
                .Select(x => x.Key.BatsmanModel).Distinct().ToList();


            var removeShot = matchStats.Where(x => x.Key.BallModel.bowingType == ballInfo.bowingType
            && x.Value.runonlastball == 0
            || x.Value.iswicketlost)
            .Select(x => x.Key.BatsmanModel).Distinct().ToList();


            if (removeShot.Any())
            {
               //shots= shots.Except(removeShot).ToList();
               shots = (from shotList in shots
                             where !removeShot.Any(
                                               x => x.shots == shotList.shots)
                             select shotList).Distinct().ToList();
            }


            fieldPosition fp;
            if (shots.Any())
            {
                fp = shots.Max(y => y.FieldPosition);
            }
            else
            {
                fp = fieldPosition.z4;
                if (prevShots.Any())
                {
                    shots = prevShots;
                }
                else
                {
                    Array values = Enum.GetValues(typeof(Shots));
                    Random random = new Random();
                    Shots randomShot = (Shots)values.GetValue(random.Next(values.Length));
                    shots = batData.Select(x => new BatsmanModel() { shots = randomShot, FieldPosition = fp }).ToList();
                }
            }

            var batSpeeds = DataHelper.GetBatSpeed();

            return new BatsmanModel()
            {
               
                shots = shots.FirstOrDefault(x => x.FieldPosition == fp).shots,
                batSpeed = new Random().Next(batSpeeds[fp], (int)Constants.BAT_MAX_SPEED),
                batsman = players.OrderBy(x => x.Order).FirstOrDefault(x => !x.IsOut).Name
            };
        }

        private List<BattingConfig> GetBattingOptions()
        {
            return DataHelper.GetBattingMatrix();
        }

    }
}
