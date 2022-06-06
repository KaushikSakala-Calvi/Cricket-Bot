using System;
using System.Collections.Generic;
using TestBot.Batting;
using TestBot.Bowling;
using TestBot.Fielding;

namespace TestBot.Model
{
    public class FieldingConfig
    {
        public BowlerTypes bowlerType { get; set; }
        public List<FieldingModel> fieldingModel { get; set; }

    }

}
