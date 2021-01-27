using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnhollowerBaseLib;
using UnityEngine;

namespace HeteroGayMod
{
    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.SetInfected))]
    public static class SetInfectedPatch
    {
        public static void Postfix(Il2CppStructArray<byte> JPGEIBIBJPJ)
        {
            PlayerControl player = PlayerControl.LocalPlayer;
            bool playerImpostor = false;
            foreach (byte b in JPGEIBIBJPJ)
            {
                if (player.PlayerId == b)
                {
                    playerImpostor = true;
                    break;
                }
            }

            if (!playerImpostor)
                return;

            foreach (PlayerControl p in PlayerControl.AllPlayerControls)
            {
                if (JPGEIBIBJPJ.Contains(p.PlayerId))
                {
                    p.nameText.Color = new Color(1f, 0.6f, 0.2f, 1f);
                }
            }
        }

    }
}
