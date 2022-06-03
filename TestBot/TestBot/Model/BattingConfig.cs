using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestBot.Model
{
    public class BattingConfig
    {
        public int Id { get; set; }
        public string BowlingType { get; set; }
        public string BowlerType { get; set; }
        public string BowlSpeed { get; set; }
        public string BowlingZone { get; set; }
        public string SelectedShot { get; set; }
    }
}
