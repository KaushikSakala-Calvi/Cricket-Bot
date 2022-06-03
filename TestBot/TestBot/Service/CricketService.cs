using System;
using System.Collections.Generic;
using TestBot.Batting;
using TestBot.Bowling;
using TestBot.Fielding;
using TestBot.Helper;

namespace TestBot.Service
{
    public class CricketService : ICricketService
    {
        //private readonly CricketRepository _cricketRepo;//commented as of now
        //public CricketService(CricketRepository cricketRepo)
        //{
        //    _cricketRepo = cricketRepo;
        //}
        public List<BattingConfig> GetAllBattingOptions()
        {
            var battingData = GetBattingOptions();//get static data from helper class
            return battingData;
        }        

        //Implement code to select the correct batting output based on Input
        public BatsmanModel GetOptimizedBattingData(BallModel ballInfo, List<FieldingModel> fieldSettings)
        {
            BatsmanModel battingInfo = new BatsmanModel();

            //Drives shot should played according to the field setting, and zone
            //If the bowler speed ranges from 90 - 110 - we should increase the bat speed
            //get all static data 
            List<BattingConfig> battingOptions = GetBattingOptions();

            //select options from intersection of field setting ,static data and bowling info
            //call rule engine class

            return battingInfo;
        }

        private List<BattingConfig> GetBattingOptions()
        {
            return DataHelper.GetBattingMatrix();
        }
    }
}
