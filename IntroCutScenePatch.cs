using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HeteroGayMod
{
    [HarmonyPatch(typeof(IntroCutscene.CoBegin__d), nameof(IntroCutscene.CoBegin__d.MoveNext))]
    public static class IntroCutScenePatch
    {
        public static void Postfix(IntroCutscene.CoBegin__d __instance)
        {
            if (__instance.isImpostor)
            {
                __instance.__this.Title.Text = "Gay";
                __instance.__this.Title.Color = new Color(1f, 0.6f, 0.2f, 1f);
                __instance.__this.BackgroundBar.material.color = new Color(1f, 0.6f, 0.2f, 1f);
            }
            else
            {
                __instance.__this.Title.Text = "Hetero";
                __instance.__this.Title.Color = new Color(0.63f, 0.46f, 1f, 1f);
                __instance.__this.ImpostorText.Text = "Try avoid catching the [FF9933FF]Gay";
                __instance.__this.BackgroundBar.material.color = new Color(0.63f, 0.46f, 1f, 1f);
            }
        }
    }
}
