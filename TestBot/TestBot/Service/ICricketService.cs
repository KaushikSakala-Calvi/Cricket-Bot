using System.Collections.Generic;
using TestBot.Batting;
using TestBot.Bowling;
using TestBot.Fielding;
using TestBot.Match;

namespace TestBot.Service
{
    public interface ICricketService
    {
        List<BattingConfig> GetAllBattingOptions();

        BatsmanModel GetOptimizedBattingData(BallModel ballInfo);

        void SaveLastBalInfo(MatchProgressModel matchProgress);
        void SaveFieldSettings(List<FieldingModel> fieldingModels);
    }
}
