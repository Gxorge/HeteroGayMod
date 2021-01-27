using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeteroGayMod
{
    [HarmonyPatch(typeof(ExileController), nameof(ExileController.Begin))]
    public static class PlayerExiledPatch
    {
        public static void Postfix(GameData.PlayerInfo LNMDIKCFBAK, bool BBJAEDLJIED)
        {
            if (LNMDIKCFBAK.PlayerId == PlayerControl.LocalPlayer.PlayerId)
            {
                HeteroGayMod.log.LogMessage("player exiled");
                HeteroGayMod.displayImpostors = true;
                HeteroGayMod.UpdateColours();
            }
        }
    }
}
