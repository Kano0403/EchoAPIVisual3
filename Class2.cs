namespace EchoAPIVisual3
{
    public class Data
    {
        public string client_name { get; set; }
        public ClientPlayer player { get; set; }
        public string sessionid { get; set; }
        public string sessionip { get; set; }
        public bool private_match { get; set; }
        public bool tournament_match { get; set; }
        public string map_name { get; set; }
        public string match_type { get; set; }
        public Disc disc { get; set; }
        public string game_status { get; set; }
        public Pause pause { get; set; }
        public int orange_team_restart_request { get; set; }
        public int blue_team_restart_request { get; set; }
        public float game_clock { get; set; }
        public string game_clock_display { get; set; }
        public int orange_points { get; set; }
        public int blue_points { get; set; }
        public Last_Score last_score { get; set; }
        public int[] possession { get; set; }
        public Team[] teams { get; set; }
    }

    public class Disc
    {
        public float[] position { get; set; }
        public float[] forward { get; set; }
        public float[] left { get; set; }
        public float[] up { get; set; }
        public float[] velocity { get; set; }
        public int bounce_count { get; set; }
    }

    public class ClientPlayer
    {
        public float[] vr_position { get; set; }
        public float[] vr_left { get; set; }
        public float[] vr_forward { get; set; }
        public float[] vr_up { get; set; }
    }

    public class Pause
    {
        public string paused_state { get; set; }
        public string unpaused_team { get; set; }
        public string paused_requested_team { get; set; }
        public float unpaused_timer { get; set; }
        public float paused_timer { get; set; }
    }

    public class Last_Score
    {
        public float disc_speed { get; set; }
        public string team { get; set; }
        public string goal_type { get; set; }
        public int point_amount { get; set; }
        public float distance_thrown { get; set; }
        public string person_scored { get; set; }
        public string assist_scored { get; set; }
    }

    public class Team
    {
        public Player[] players { get; set; }
        public string team { get; set; }
        public bool possession { get; set; }
        public Stats stats { get; set; }
    }

    public class Stats
    {
        public int points { get; set; }
        public float possession_time { get; set; }
        public int interceptions { get; set; }
        public int blocks { get; set; }
        public int steals { get; set; }
        public int catches { get; set; }
        public int passes { get; set; }
        public int saves { get; set; }
        public int goals { get; set; }
        public int stuns { get; set; }
        public int assists { get; set; }
        public int shots_taken { get; set; }
    }

    public class Player
    {
        public string name { get; set; }
        public long userid { get; set; }
        public int playerid { get; set; }
        public int ping { get; set; }
        public int level { get; set; }
        public int number { get; set; }
        public BPart rhand { get; set; }
        public Stats stats { get; set; }
        public bool stunned { get; set; }
        public bool invulnerable { get; set; }
        public BPart head { get; set; }
        public bool possession { get; set; }
        public BPart body { get; set; }
        public BPart lhand { get; set; }
        public bool blocking { get; set; }
        public float[] velocity { get; set; }
    }

    public class BPart
    {
        public float[] position { get; set; }
        public float[] forward { get; set; }
        public float[] left { get; set; }
        public float[] up { get; set; }
    }
}