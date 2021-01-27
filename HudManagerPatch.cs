using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeteroGayMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public static class HudManagerPatch
    {
        public static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count > 1 && HeteroGayMod.impostors.Count > 0)
            {
                if (HeteroGayMod.displayImpostors)
                {
                    HeteroGayMod.UpdateColours();
                }
            }
        }
    }
}
