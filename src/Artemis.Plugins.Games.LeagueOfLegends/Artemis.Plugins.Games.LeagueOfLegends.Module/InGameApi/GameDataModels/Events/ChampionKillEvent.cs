﻿namespace Artemis.Plugins.Games.LeagueOfLegends.Module.InGameApi.GameDataModels.Events
{
    public class ChampionKillEvent : LolEvent
    {
        public string KillerName { get; set; }
        public string VictimName { get; set; }
        public string[] Assisters { get; set; }
    }
}
