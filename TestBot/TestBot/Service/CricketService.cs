﻿using System.Linq;
using System.Collections.Generic;
using TestBot.Batting;
using TestBot.Bowling;
using TestBot.Fielding;
using TestBot.Helper;
using TestBot.Match;
using TestBot.Model;

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
        public List<BattingConfig> GetAllBattingOptions()
        {
            var battingData = GetBattingOptions();//get static data from helper class
            return battingData;
        }

        //Implement code to select the correct batting output based on Input
        public BatsmanModel GetOptimizedBattingData(BallModel ballInfo, List<FieldingModel> fieldSettings)
        {
            //Drives shot should played according to the field setting, and zone
            //If the bowler speed ranges from 90 - 110 - we should increase the bat speed
            //get all static data 
            List<BattingConfig> battingOptions = GetBattingOptions();

            //caluclate the shot
            var batData = battingOptions
                                .Where(x => x.BowlerType == ballInfo.bowlerType
                                    && x.BowlingZone == ballInfo.zone
                                    && ballInfo.speed <= x.MinBowlSpeed
                                    && x.MaxBowlSpeed <= ballInfo.speed);

            BattingConfig possibleShot;
            if (matchStats.Values.Any())
            {
                possibleShot = GetBestPossibleShot(ballInfo, batData);
            }
            else
            {
                possibleShot = batData.First();
            }
            //select options from intersection of field setting ,static data and bowling info
            //call rule engine class
            var batsManModel = CreateBattingModel(possibleShot);
            matchStats.Add(new HybridModel() { BallModel = ballInfo, BatsmanModel = batsManModel }, null);
            return batsManModel;
        }

        public void SaveLastBalInfo(MatchProgressModel matchProgress)
        {
            if (matchStats.Any())
                matchStats[matchStats.Keys.Last()] = matchProgress;
        }

        private BatsmanModel CreateBattingModel(BattingConfig possibleShot)
        {
            return new BatsmanModel()
            {
                shots = possibleShot.SelectedShot
            };
        }

        private BattingConfig GetBestPossibleShot(BallModel ballInfo, IEnumerable<BattingConfig> batData)
        {
            var result = matchStats.Where(x => x.Key.
                            BallModel.bowingType == ballInfo.bowingType
                             && x.Key.BallModel.bowlerType == ballInfo.bowlerType
                             && x.Key.BallModel.zone == ballInfo.zone
                             && !x.Value.isMissed
                             && !x.Value.iswicketlost)
                        .Select(x => new
                        {
                            Shot = x.Key.BatsmanModel.shots,
                            Runs = x.Value.runonlastball
                        })
                        .GroupBy(x => x.Runs)
                        .Select(x => x.OrderByDescending(g => g.Runs).FirstOrDefault())
                        .FirstOrDefault();


            return new BattingConfig()
            {
                BowlerType = ballInfo.bowlerType,
                BowlingType = ballInfo.bowingType,
                BowlingZone = ballInfo.zone,
                SelectedShot = result.Shot
            };
        }

        private List<BattingConfig> GetBattingOptions()
        {
            return DataHelper.GetBattingMatrix();
        }

    }
}