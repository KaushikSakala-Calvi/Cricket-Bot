using System.Collections.Generic;
using TestBot.Batting;
using TestBot.Bowling;
using TestBot.Fielding;

namespace TestBot.Matrix
{
    public class FieldingMatrix : IFieldingMatrix
    {
        public List<FieldingModel> GetFeildSetting(BowlerTypes bowlerType)
        {
            var result = new List<FieldingModel>();

            #region RAF

            var RAFfieldingPositions = new List<FieldingModel>();
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.latecut });
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Cut });
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.squarecut });
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Squaredrive });
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.Coverdrive });
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.Offdrive });
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.Ondrive });
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.hook });
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.pull });

            #endregion

            #region RAFM

            var RAMFfieldingPositions = new List<FieldingModel>();
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.latecut });
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Cut });
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.squarecut });
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Squaredrive });
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.Coverdrive });
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.Offdrive });
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.Ondrive });
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.hook });
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.pull });

            #endregion

            #region RAS
            var RASfieldingPositions = new List<FieldingModel>();
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.latecut });
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Cut });
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.squarecut });
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Squaredrive });
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.Coverdrive });
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.Offdrive });
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.Ondrive });
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.hook });
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.pull });
            #endregion

            #region OB
            var OBfieldingPositions = new List<FieldingModel>();
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.latecut });
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Cut });
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.squarecut });
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Squaredrive });
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.hook });
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.Offdrive });
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.Ondrive });
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Sweep });
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.pull });
            #endregion

            #region LB
            var LBfieldingPositions = new List<FieldingModel>();
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.latecut });
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Cut });
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.squarecut });
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Squaredrive });
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.Coverdrive });
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.Offdrive });
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.Ondrive });
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Sweep });
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.pull });
            #endregion

            switch (bowlerType)
            {
                case BowlerTypes.RAF:
                    result = RAFfieldingPositions;
                    break;
                case BowlerTypes.RAFM:
                    result = RAMFfieldingPositions;
                    break;
                case BowlerTypes.RAS:
                    result = RASfieldingPositions;
                    break;
                case BowlerTypes.OB:
                    result = OBfieldingPositions;
                    break;
                case BowlerTypes.LB:
                    result = LBfieldingPositions;
                    break;
            }
            return result;
        }
    }
}
