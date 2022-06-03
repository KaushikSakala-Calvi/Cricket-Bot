using System.Collections.Generic;
using TestBot.Batting;
using TestBot.Bowling;
using TestBot.Fielding;

namespace TestBot.Service
{
    public interface ICricketService
    {
        List<BattingConfig> GetAllBattingOptions();

        BatsmanModel GetOptimizedBattingData(BallModel ballInfo, List<FieldingModel> fieldSettings);

    }
}
