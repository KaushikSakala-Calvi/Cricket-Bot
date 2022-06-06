using System.Collections.Generic;
using TestBot.Batting;
using TestBot.Bowling;
using TestBot.Fielding;
using TestBot.Model;

namespace TestBot.Helper
{
    public static class DataHelper
    {
        public static List<BattingConfig> GetBattingMatrix()
        {
            return new List<BattingConfig>()
            {
                #region RAF
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.pull},
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.hook},
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Coverdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Offdrive},

                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Cut},
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.squarecut},
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Straightdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Coverdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Squaredrive},

                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Straightdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Ondrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Ondrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Straightdrive},

                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 141,MaxBowlSpeed=160,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.squarecut},
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 141,MaxBowlSpeed=160,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Uppercut},
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 141,MaxBowlSpeed=160,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Defensiveshot},

                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 141,MaxBowlSpeed=160,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Cut},
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 141,MaxBowlSpeed=160,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Coverdrive},

                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 141,MaxBowlSpeed=160,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Ondrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 141,MaxBowlSpeed=160,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Straightdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 141,MaxBowlSpeed=160,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Straightdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAF,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 141,MaxBowlSpeed=160,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Straightdrive},
                #endregion

                #region RAFM
                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 110,MaxBowlSpeed=125,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 110,MaxBowlSpeed=125,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Ondrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 110,MaxBowlSpeed=125,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Straightdrive},

                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 110,MaxBowlSpeed=125,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Cut},
                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 110,MaxBowlSpeed=125,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Coverdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 110,MaxBowlSpeed=125,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Offdrive},

                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 110,MaxBowlSpeed=125,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Ondrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 110,MaxBowlSpeed=125,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Straightdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 110,MaxBowlSpeed=125,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Ondrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 110,MaxBowlSpeed=125,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Straightdrive},

                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.pull},
                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.hook},
                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Coverdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Offdrive},

                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Cut},
                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Coverdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Offdrive},

                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Ondrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Straightdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Ondrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAFM,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 125,MaxBowlSpeed=140,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Straightdrive},
                #endregion

                #region RAS
                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Offdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.latecut},
                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Coverdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Offdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Ondrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Straightdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Ondrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Straightdrive},

                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 110,MaxBowlSpeed=130,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.pull},
                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 110,MaxBowlSpeed=130,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.hook},
                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 110,MaxBowlSpeed=130,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Coverdrive},

                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.latecut},
                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Coverdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Offdrive},

                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 110,MaxBowlSpeed=130,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Ondrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 110,MaxBowlSpeed=130,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Straightdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 110,MaxBowlSpeed=130,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Ondrive},
                new BattingConfig(){ BowlerType = BowlerTypes.RAS,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 110,MaxBowlSpeed=130,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Straightdrive},
                #endregion

                #region OB
                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Defensiveshot},

                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Defensiveshot},

                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Defensiveshot},

                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.OffBreak,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Coverdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.OffBreak,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Offdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.OffBreak,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.latecut},

                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.Googly,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Ondrive},
                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.Googly,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Ondrive},

                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},

                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.OffBreak,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Coverdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.OffBreak,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Offdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.OffBreak,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.squarecut},

                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.Googly,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Straightdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.OB,BowlingType = BowlingType.Googly,MinBowlSpeed = 90,MaxBowlSpeed=110,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Straightdrive},
                #endregion

                #region LB
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Defensiveshot},

                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.LegBreak,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.hook},
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.LegBreak,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Sweep},
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.Googly,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Ondrive},
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.Googly,MinBowlSpeed = 75,MaxBowlSpeed=90,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Ondrive},


                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 90,MaxBowlSpeed=120,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.Bouncer,MinBowlSpeed = 90,MaxBowlSpeed=120,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 90,MaxBowlSpeed=120,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.Outswinger,MinBowlSpeed = 90,MaxBowlSpeed=120,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 90,MaxBowlSpeed=120,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Defensiveshot},
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.Inswingers,MinBowlSpeed = 90,MaxBowlSpeed=120,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Defensiveshot},

                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.LegBreak,MinBowlSpeed =90,MaxBowlSpeed=120,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.hook},
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.LegBreak,MinBowlSpeed =90,MaxBowlSpeed=120,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Sweep},
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.Googly,MinBowlSpeed = 90,MaxBowlSpeed=120,BowlingZone = BallPitchZone.zone1,SelectedShot=Shots.Straightdrive},
                new BattingConfig(){ BowlerType = BowlerTypes.LB,BowlingType = BowlingType.Googly,MinBowlSpeed = 90,MaxBowlSpeed=120,BowlingZone = BallPitchZone.zone2,SelectedShot=Shots.Straightdrive}
                #endregion
            };
        }

        public static List<FieldingConfig> GetFeildMatrix()
        {
            #region RAF

            var RAFfieldingPositions = new List<FieldingModel>();
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.pull});
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.pull});
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.pull});
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.pull});
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.pull});
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.pull});
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.pull});
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.pull});
            RAFfieldingPositions.Add(new FieldingModel() { fp = fieldPosition.z4, Prvshot = Shots.pull});

            #endregion

            return new List<FieldingConfig>()
            {
                
            };
        }
    }
}
