using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;
using Reactor;
using UnhollowerBaseLib;
using UnityEngine;

namespace HeteroGayMod
{
    [BepInPlugin(Id)]
    [BepInProcess("Among Us.exe")]
    [BepInDependency(ReactorPlugin.Id)]
    public class HeteroGayMod : BasePlugin
    {
        public const string Id = "moe.gabriella.heterogay";

        public Harmony Harmony { get; } = new Harmony(Id);

        public ConfigEntry<string> Name { get; private set; }

        public static ManualLogSource log;

        public override void Load()
        {
            HeteroGayMod.log = base.Log;
            Harmony.PatchAll();

            HeteroGayMod.log.LogMessage("loaded");
        }
    }
}
