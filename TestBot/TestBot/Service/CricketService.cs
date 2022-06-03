using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBot.Batting;
using TestBot.Bowling;
using TestBot.Fielding;
using TestBot.Model;

namespace TestBot.Service
{
    public class CricketService
    {
        //private readonly CricketRepository _cricketRepo;//commented as of now
        //public CricketService(CricketRepository cricketRepo)
        //{
        //    _cricketRepo = cricketRepo;
        //}
        public List<BattingConfig> GetAllBattingOptions()
        {
            var battingData = GetAllBattingOptions();//get static data from helper class
            return battingData;
        }
        //Implement code to select the correct batting output based on Input
        public BatsmanModel GetOptimizedBattingData(BallModel ballInfo,List<FieldingModel> fieldSettings)
        {
            BatsmanModel battingInfo=new BatsmanModel();
            //get all static data 
            List<BattingConfig> battingOptions=GetAllBattingOptions();

            //select options from intersection of field setting ,static data and bowling info
            //call rule engine class

            return battingInfo;

        }
    }
}
