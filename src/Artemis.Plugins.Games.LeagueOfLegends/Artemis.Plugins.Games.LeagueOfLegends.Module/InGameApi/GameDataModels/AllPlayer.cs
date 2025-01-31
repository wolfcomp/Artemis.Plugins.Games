﻿using Newtonsoft.Json;

namespace Artemis.Plugins.Games.LeagueOfLegends.Module.InGameApi.GameDataModels
{
    public class AllPlayer
    {
        public string ChampionName { get; set; }
        public bool IsBot { get; set; }
        public bool IsDead { get; set; }
        public Item[] Items { get; set; }
        public int Level { get; set; }
        public string Position { get; set; }
        public string RawChampionName { get; set; }
        public float RespawnTimer { get; set; }
        public Runes Runes { get; set; } = new();
        public Scores Scores { get; set; } = new();
        public int SkinID { get; set; }
        public string SummonerName { get; set; }
        public SummonerSpells SummonerSpells { get; set; } = new();
        public string Team { get; set; }

        #region Optional
        [JsonProperty(Required = Required.Default)]
        public string SkinName { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string RawSkinName { get; set; }
        #endregion
    }
}
