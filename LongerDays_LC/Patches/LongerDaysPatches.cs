using HarmonyLib;
using LongerDays_LC.Configuration;
using System;

namespace LongerDays_LC.LongerDays_LC.Patches
{
  [HarmonyPatch(typeof(TimeOfDay), "Start")]
  internal class TimeOfDayPatches
  {
    /**
     * Patches - Class of TimeOfDay patches for Lethal Company to change the length of each day
     */
    public static void Prefix(ref TimeOfDay __instance)
    {
      /**
       * Changes lengthOfHours modifier
       * Default is 100f which translates to each day being 660 seconds.
       * This actual length of a day is modified based on your current level.
      */
      
      LongerDays_LCPlugin.Log.LogMessage($"Config.LengthOfHoursMod={Config.LengthOfHoursMod}");

      if (Config.LengthOfHoursMod > 0f) {

        __instance.lengthOfHours = Config.LengthOfHoursMod; // 100f by default
        LongerDays_LCPlugin.Log.LogMessage($"lengthOfHours value={__instance.lengthOfHours}");

      }
    }
  }
}