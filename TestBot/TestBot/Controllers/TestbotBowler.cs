using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestBot.Batting;
using TestBot.Bowling;
using TestBot.Fielding;
using TestBot.Match;
using TestBot.Matrix;
using TestBot.Service;

namespace TestBot.Controllers
{
    [Route("api/CricketBot")]
    [ApiController]
    public class TestbotBowler : ControllerBase
    {
        private readonly ICricketService _cricketService;
        private readonly IBowlingMatirx _bowlingMatirx;
        private readonly IFieldingMatrix _fieldingMatrix;

        private static BowlerTypes currentBowlingType = BowlerTypes.RAF;


        public TestbotBowler(ICricketService cricketService, IBowlingMatirx bowlingMatirx, IFieldingMatrix fieldingMatrix)
        {
            _cricketService = cricketService;
            _bowlingMatirx = bowlingMatirx;
            _fieldingMatrix = fieldingMatrix;
        }


        [HttpGet]
        [Route("GetNextBall")]
        public BallModel GetNextBall()
        {
            
            var nextBallDetails = _bowlingMatirx.getNextBall();
            currentBowlingType = nextBallDetails.bowlerType;
            return nextBallDetails;
            //return new BallModel
            //{
            //    bowingType = BowlingType.Outswinger,
            //    bowlerName = "Rohit",
            //    bowlerType = BowlerTypes.RAF,
            //    speed = 140,
            //    zone = BallPitchZone.zone1
            //};
        }

        [HttpPost]
        [Route("PostBalldata")]
        public BatsmanModel PostBalldata(BallModel nextball)
        {
            //var ballThrown=new BallModel 
            //{
            //    bowingType = BowlingType.Outswinger,
            //    bowlerName = "Rohit",
            //    bowlerType = BowlerTypes.RAF,
            //    speed = 140,
            //    zone = BallPitchZone.zone1
            //};
            var batsmanModel = _cricketService.GetOptimizedBattingData(nextball);
            return batsmanModel;
        }
        [HttpPost]
        [Route("Postfieldsetting")]
        public HttpStatusCode Postfieldsetting(List<FieldingModel> fieldingModels)
        {
            _cricketService.SaveFieldSettings(fieldingModels);
            return HttpStatusCode.OK;
        }


        [HttpPost]
        [Route("PostLastballStatus")]
        public HttpStatusCode PostLastballStatus(MatchProgressModel matchProgress)
        {
            _cricketService.SaveLastBalInfo(matchProgress);
            return HttpStatusCode.OK;
        }


        [HttpGet]
        [Route("Getfieldsetting")]
        public List<FieldingModel> Getfieldsetting()
        {
            return _fieldingMatrix.GetFeildSetting(currentBowlingType);
            //List<FieldingModel> fieldingModels = new List<FieldingModel>();
            //fieldingModels.Add(new FieldingModel { fp = fieldPosition.z1, Prvshot = Shots.Coverdrive });
            //return fieldingModels;
        }

        [HttpGet]
        [Route("Toss")]
        public Toss GetTossCall()
        {
            return Toss.Tail;
        }

    }
}
