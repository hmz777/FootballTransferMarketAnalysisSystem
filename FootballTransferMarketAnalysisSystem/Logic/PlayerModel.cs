using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetClips.Logic
{
    public class PlayerModel
    {
        [Multislot]
        public string long_name { get; set; }
        public string age { get; set; }
        public string height_cm { get; set; }
        [Multislot]
        public string nationality { get; set; }
        [Multislot]
        public string club_name { get; set; }
        [Multislot]
        public string league_name { get; set; }
        public string value_eur { get; set; }
        public string potential { get; set; }
        public string overall { get; set; }
        public string preferred_foot { get; set; }
        [AvgValue(Value = 2)]
        public string skill_moves { get; set; }
        public string team_position { get; set; }
        public string nation_position { get; set; }
        [AvgValue(Value = 67)]
        public string pace { get; set; }
        [AvgValue(Value = 52)]
        public string shooting { get; set; }
        [AvgValue(Value = 57)]
        public string passing { get; set; }
        [AvgValue(Value = 62)]
        public string dribbling { get; set; }
        [AvgValue(Value = 51)]
        public string defending { get; set; }
        [AvgValue(Value = 64)]
        public string physic { get; set; }
        [AvgValue(Value = 65)]
        public string gk_diving { get; set; }
        [AvgValue(Value = 62)]
        public string gk_handling { get; set; }
        [AvgValue(Value = 61)]
        public string gk_kicking { get; set; }
        [AvgValue(Value = 66)]
        public string gk_reflexes { get; set; }
        [AvgValue(Value = 37)]
        public string gk_speed { get; set; }
        [AvgValue(Value = 49)]
        public string attacking_crossing { get; set; }
        [AvgValue(Value = 45)]
        public string attacking_finishing { get; set; }
        [AvgValue(Value = 51)]
        public string attacking_heading_accuracy { get; set; }
        [AvgValue(Value = 58)]
        public string attacking_short_passing { get; set; }
        [AvgValue(Value = 42)]
        public string attacking_volleys { get; set; }
        [AvgValue(Value = 55)]
        public string skill_dribbling { get; set; }
        [AvgValue(Value = 52)]
        public string skill_long_passing { get; set; }
        [AvgValue(Value = 58)]
        public string skill_ball_control { get; set; }
        [AvgValue(Value = 64)]
        public string movement_acceleration { get; set; }
        [AvgValue(Value = 64)]
        public string movement_sprint_speed { get; set; }
        [AvgValue(Value = 63)]
        public string movement_agility { get; set; }
        [AvgValue(Value = 57)]
        public string power_shot_power { get; set; }
        [AvgValue(Value = 64)]
        public string power_long_shots { get; set; }
        [AvgValue(Value = 55)]
        public string mentality_aggression { get; set; }
        [AvgValue(Value = 46)]
        public string mentality_interceptions { get; set; }
        [AvgValue(Value = 47)]
        public string defending_standing_tackle { get; set; }
        [AvgValue(Value = 45)]
        public string defending_sliding_tackle { get; set; }
        [Multislot]
        public string player_positions { get; set; }
    }
}
