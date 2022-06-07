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
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Coverdrive });
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z1, Prvshot = Shots.latecut });
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Ondrive });
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.pull });
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.Offdrive });
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Sweep });
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.hook });
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.squarecut });
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.Ondrive });
            #endregion

            #region RAFM
            var RAMFfieldingPositions = new List<FieldingModel>();
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Coverdrive });
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z1, Prvshot = Shots.latecut });
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Ondrive });
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.pull });
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.Offdrive });
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Sweep });
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.hook });
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.squarecut });
            RAMFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.Ondrive });
            #endregion

            #region RAS
            var RASfieldingPositions = new List<FieldingModel>();
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Coverdrive });
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z1, Prvshot = Shots.Coverdrive });
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Ondrive });
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.pull });
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Offdrive });
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.Sweep });
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z3, Prvshot = Shots.hook });
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.squarecut });
            RASfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z1, Prvshot = Shots.Ondrive });
            #endregion

            #region OB
            var OBfieldingPositions = new List<FieldingModel>();
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Coverdrive });
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z1, Prvshot = Shots.Coverdrive });
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Ondrive });
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.pull });
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Offdrive });
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Sweep });
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z1, Prvshot = Shots.hook });
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.squarecut });
            OBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z1, Prvshot = Shots.Ondrive });
            #endregion

            #region LB
            var LBfieldingPositions = new List<FieldingModel>();
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.Coverdrive });
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z1, Prvshot = Shots.Coverdrive });
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.hook });
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.pull });
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z1, Prvshot = Shots.Offdrive });
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z1, Prvshot = Shots.latecut });
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z1, Prvshot = Shots.hook });
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z2, Prvshot = Shots.squarecut });
            LBfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z1, Prvshot = Shots.Ondrive });
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
