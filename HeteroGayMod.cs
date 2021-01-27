using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;
using Reactor;
using System.Collections.Generic;
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
        public static List<PlayerControl> impostors;

        public static bool displayImpostors;

        public override void Load()
        {
            displayImpostors = false;
            impostors = new List<PlayerControl>();
            log = base.Log;
            Harmony.PatchAll();

            log.LogMessage("loaded");
        }

        public static void UpdateColours()
        {
            if (displayImpostors)
            {
                foreach (PlayerControl impostor in impostors)
                {
                    impostor.nameText.Color = new Color(1f, 0.6f, 0.2f, 1f);
                }
            }
        }

        public static bool IsImpostor(int id)
        {
            foreach (PlayerControl impostor in impostors)
            {
                if (impostor.PlayerId == id)
                    return true;
            }
            return false;
        }
    }
}
