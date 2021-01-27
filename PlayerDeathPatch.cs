using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;

namespace HeteroGayMod
{
    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.MurderPlayer))]
    public static class PlayerDeathPatch
    {
        public static void Postfix(PlayerControl __instance, PlayerControl CAKODNGLPDF) // __instance = killer, CAKODNGLPDF = player
        {
            if (CAKODNGLPDF.PlayerId == PlayerControl.LocalPlayer.PlayerId) // Player is dead
            {
                HeteroGayMod.log.LogMessage("player killed");
                HeteroGayMod.displayImpostors = true;
                HeteroGayMod.UpdateColours();
            }
        }
    }
}
