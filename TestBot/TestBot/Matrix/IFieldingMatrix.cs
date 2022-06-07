using System.Collections.Generic;
using TestBot.Bowling;
using TestBot.Fielding;

namespace TestBot.Matrix
{
    public interface IFieldingMatrix
    {
        List<FieldingModel> GetFeildSetting(BowlerTypes bowlerType);
    }
}