using BepInEx;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;
using System;

namespace HeteroGayMod
{
    [BepInPlugin("moe.gabriella.heterogay", "Hetero-Gay Mod", "1.0.0")]
    public class HeteroGayMod : BasePlugin
    {
        public static ManualLogSource log;
        private readonly Harmony harmony;

        public HeteroGayMod()
        {
            HeteroGayMod.log = base.Log;
            this.harmony = new Harmony("Hetero-Gay Mod");
        }

        public override void Load()
        {
            this.harmony.PatchAll();
            HeteroGayMod.log.LogMessage("Loaded the Hetero-Gay Mod!");
        }
    }
}
