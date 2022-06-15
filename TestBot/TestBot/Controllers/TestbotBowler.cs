using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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
        private readonly ILogger _logger;

        private static BowlerTypes currentBowlingType = BowlerTypes.RAF;
        private static MatchProgressModel progressModel;


        public TestbotBowler(ICricketService cricketService, IBowlingMatirx bowlingMatirx, IFieldingMatrix fieldingMatrix, ILogger<TestbotBowler> logger)
        {
            _cricketService = cricketService;
            _bowlingMatirx = bowlingMatirx;
            _fieldingMatrix = fieldingMatrix;
            _logger = logger;
        }


        [HttpGet]
        [Route("GetNextBall")]
        public BallModel GetNextBall()
        {
            var nextBallDetails = _bowlingMatirx.getNextBall(progressModel);
            currentBowlingType = nextBallDetails.bowlerType;            
            _logger.LogInformation( "GetNextBall-Output : "+ JsonConvert.SerializeObject(nextBallDetails));
            return nextBallDetails;
        }

        [HttpPost]
        [Route("PostBalldata")]
        public BatsmanModel PostBalldata(BallModel nextball)
        {
            LogHelper.LogMessage(nextball, "PostBalldata-Input");
            var batsmanModel = _cricketService.GetOptimizedBattingData(nextball);
            _logger.LogInformation( "PostBalldata-Output : " + JsonConvert.SerializeObject(batsmanModel));
            return batsmanModel;
        }

        [HttpPost]
        [Route("Postfieldsetting")]
        public HttpStatusCode Postfieldsetting(List<FieldingModel> fieldingModels)
        {
            _logger.LogInformation( "Postfieldsetting-Input : " + JsonConvert.SerializeObject(fieldingModels));
            _cricketService.SaveFieldSettings(fieldingModels);
            return HttpStatusCode.OK;
        }


        [HttpPost]
        [Route("PostLastballStatus")]
        public HttpStatusCode PostLastballStatus(MatchProgressModel matchProgress)
        {
            _logger.LogInformation( "PostLastballStatus-Input : " + JsonConvert.SerializeObject(matchProgress));
            progressModel = matchProgress;
            _cricketService.SaveLastBalInfo(matchProgress);
            return HttpStatusCode.OK;
        }


        [HttpGet]
        [Route("Getfieldsetting")]
        public List<FieldingModel> Getfieldsetting()
        {
            var fieldSettings = _fieldingMatrix.GetFeildSetting(currentBowlingType);
            _logger.LogInformation( "Getfieldsetting-Output : " + JsonConvert.SerializeObject(fieldSettings));

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
