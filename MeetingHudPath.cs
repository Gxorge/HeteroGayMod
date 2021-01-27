using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HeteroGayMod
{
    [HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.Update))]
    public static class MeetingHudPatch
    {
        public static void Postfix(MeetingHud __instance)
        {
            if (!HeteroGayMod.displayImpostors)
                return;

            foreach (PlayerVoteArea player in __instance.playerStates)
            {
                if (HeteroGayMod.IsImpostor(player.TargetPlayerId))
                {
                    player.NameText.Color = new Color(1f, 0.6f, 0.2f, 1f);
                }
            }
        }
    }
}
