﻿using System;
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


        public TestbotBowler(ICricketService cricketService, IBowlingMatirx bowlingMatirx)
        {
            _cricketService = cricketService;
            _bowlingMatirx = bowlingMatirx;
        }


        [HttpGet]
        [Route("GetNextBall")]
        public BallModel GetNextBall()
        {
            return _bowlingMatirx.getNextBall();

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
            var ballThrown=new BallModel 
            {
                bowingType = BowlingType.Outswinger,
                bowlerName = "Rohit",
                bowlerType = BowlerTypes.RAF,
                speed = 140,
                zone = BallPitchZone.zone1
            };
            var battingOption = _cricketService.GetOptimizedBattingData(ballThrown);
            return new BatsmanModel
            {
                batSpeed = 60 ,
                shots = Shots.Cut,
                batsman = "KapilDev"
            };
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
            List<FieldingModel> fieldingModels = new List<FieldingModel>();
            fieldingModels.Add(new FieldingModel { fp = fieldPosition.z1, Prvshot = Shots.Coverdrive });
            return fieldingModels;
        }

        [HttpGet]
        [Route("Toss")]
        public Toss GetTossCall()
        {
            return Toss.Tail;
        }

    }
}
