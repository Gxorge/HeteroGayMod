using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using UnhollowerBaseLib;

namespace HeteroGayMod
{
    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.SetInfected))]
    public static class SetInfectedPatch
    {
        public static void Postfix(Il2CppStructArray<byte> JPGEIBIBJPJ)
        {
            HeteroGayMod.impostors.Clear();
            HeteroGayMod.displayImpostors = false;
            PlayerControl player = PlayerControl.LocalPlayer;
            foreach (byte b in JPGEIBIBJPJ)
            {
                if (player.PlayerId == b)
                {
                    HeteroGayMod.displayImpostors = true;
                    break;
                }
            }

            foreach (PlayerControl p in PlayerControl.AllPlayerControls)
            {
                if (JPGEIBIBJPJ.Contains(p.PlayerId))
                {
                    HeteroGayMod.impostors.Add(p);
                }
            }
            HeteroGayMod.UpdateColours();
        }

    }
}
