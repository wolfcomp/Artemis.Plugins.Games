﻿using Artemis.Plugins.Games.LeagueOfLegends.Module.Utils;

namespace Artemis.Plugins.Games.LeagueOfLegends.Module.InGameApi.DataModels.Enums
{
    public enum SummonerSpell
    {
        Unknown = -1,

        None = 0,

        [Name("GeneratedTip_SummonerSpell_SummonerBoost_DisplayName")]
        Cleanse,

        [Name("GeneratedTip_SummonerSpell_SummonerExhaust_DisplayName")]
        Exhaust,

        [Name("GeneratedTip_SummonerSpell_SummonerFlash_DisplayName")]
        Flash,

        [Name("GeneratedTip_SummonerSpell_SummonerFlashPerksHextechFlashtraptionV2_DisplayName")]
        HexFlash,

        [Name("GeneratedTip_SummonerSpell_SummonerHaste_DisplayName")]
        Ghost,

        [Name("GeneratedTip_SummonerSpell_SummonerHeal_DisplayName")]
        Heal,

        [Name("GeneratedTip_SummonerSpell_SummonerSmite_DisplayName")]
        Smite,

        [Name("GeneratedTip_SummonerSpell_S5_SummonerSmiteDuel_DisplayName")]
        ChallengingSmite,

        [Name("GeneratedTip_SummonerSpell_S5_SummonerSmitePlayerGanker_DisplayName")]
        ChillingSmite,

        [Name("GeneratedTip_SummonerSpell_SummonerTeleport_DisplayName")]
        Teleport,

        [Name("GeneratedTip_SummonerSpell_SummonerMana_DisplayName")]
        Clarity,

        [Name("GeneratedTip_SummonerSpell_SummonerDot_DisplayName")]
        Ignite,

        [Name("GeneratedTip_SummonerSpell_SummonerBarrier_DisplayName")]
        Barrier,

        [Name("GeneratedTip_SummonerSpell_SummonerSnowball_DisplayName")]
        Mark
    }
}
