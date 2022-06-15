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
using TestBot.Helper;
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
        private static MatchProgressModel progressModel = new MatchProgressModel();


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
            LogHelper.LogMessage(nextBallDetails, "GetNextBall-Output");
            return nextBallDetails;
        }

        [HttpPost]
        [Route("PostBalldata")]
        public BatsmanModel PostBalldata(BallModel nextball)
        {
            LogHelper.LogMessage(nextball, "PostBalldata-Input");
            var batsmanModel = _cricketService.GetOptimizedBattingData(nextball);
            LogHelper.LogMessage(batsmanModel, "PostBalldata-Output");
            return batsmanModel;
        }

        [HttpPost]
        [Route("Postfieldsetting")]
        public HttpStatusCode Postfieldsetting(List<FieldingModel> fieldingModels)
        {
            LogHelper.LogMessage(fieldingModels, "Postfieldsetting-Input");
            _cricketService.SaveFieldSettings(fieldingModels);
            return HttpStatusCode.OK;
        }


        [HttpPost]
        [Route("PostLastballStatus")]
        public HttpStatusCode PostLastballStatus(MatchProgressModel matchProgress)
        {
            LogHelper.LogMessage(matchProgress, "PostLastballStatus-Input");
            progressModel = matchProgress;
            _cricketService.SaveLastBalInfo(matchProgress);
            return HttpStatusCode.OK;
        }


        [HttpGet]
        [Route("Getfieldsetting")]
        public List<FieldingModel> Getfieldsetting()
        {
            var fieldSettings = _fieldingMatrix.GetFeildSetting(currentBowlingType);
            LogHelper.LogMessage(fieldSettings, "Getfieldsetting-Output");

            return fieldSettings;
        }

        [HttpGet]
        [Route("Toss")]
        public Toss GetTossCall()
        {
            return Toss.Tail;
        }

    }
}
