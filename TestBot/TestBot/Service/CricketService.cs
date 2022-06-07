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
                                    && ballInfo.speed <= x.MinBowlSpeed
                                    && x.MaxBowlSpeed <= ballInfo.speed);

            if(!batData.Any())
            {

            }

            BatsmanModel batsmanModel = GetBestPossibleShot(batData);

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

        private BatsmanModel GetBestPossibleShot(IEnumerable<BattingConfig> batData)
        {
            var shots = batData.Join(latestFieldSettings,
                                    bat => bat.SelectedShot,
                                    field => field.Prvshot,
                                    (bat, field) => new BatsmanModel() { shots = bat.SelectedShot, FieldPosition = field.fp });

            var fp = shots.Max(y => y.FieldPosition);
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
