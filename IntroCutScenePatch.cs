using HarmonyLib;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeteroGayMod
{
    [HarmonyPatch]
    public static class IntroCutScenePatch
    {
        [HarmonyPatch(typeof(PENEIDJGGAF.CKACLKCOJFO), "MoveNext")]
        public static void Postfix(PENEIDJGGAF.CKACLKCOJFO __instance)
        {
            bool isImpostor = FFGALNAPKCD.LocalPlayer.NDGFFHMFGIG.DAPKNDBLKIA;
            if (isImpostor)
            {
                __instance.field_Public_PENEIDJGGAF_0.Title.Text = "Gay";
                __instance.field_Public_PENEIDJGGAF_0.Title.Color = new Color(1f, 0.6f, 0.2f, 1f);
                __instance.field_Public_PENEIDJGGAF_0.ImpostorText.Text = "Pass the [FF9933FF]Gay [FFFFFF]to the [A075FFFF]Heteros"; // doesnt actually show pepesad
                __instance.field_Public_PENEIDJGGAF_0.BackgroundBar.material.color = new Color(1f, 0.6f, 0.2f, 1f);
            }
            else
            {
                __instance.field_Public_PENEIDJGGAF_0.Title.Text = "Hetero";
                __instance.field_Public_PENEIDJGGAF_0.Title.Color = new Color(0.63f, 0.46f, 1f, 1f);
                __instance.field_Public_PENEIDJGGAF_0.ImpostorText.Text = "Try avoid catching the [FF9933FF]Gay";
                __instance.field_Public_PENEIDJGGAF_0.BackgroundBar.material.color = new Color(0.63f, 0.46f, 1f, 1f);
            }
        }
    }
}
