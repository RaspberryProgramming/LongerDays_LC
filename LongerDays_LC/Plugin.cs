using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace LongerDays_LC
{
  [BepInPlugin(GUID, NAME, VERSION)]
  internal class LongerDays_LCPlugin : BaseUnityPlugin
  {
    public const string GUID = "com.github.raspberryprogramming.LongerDays_LC";
    public const string NAME = "LongerDays_LC";
    public const string VERSION = "1.0";

    public static ManualLogSource Log;

    private void Awake()
    {
      Log = Logger;
      Log.LogMessage("Starting LongerDays_LC Patching");
      Configuration.Config.Init();
      Harmony harmony = new Harmony(GUID);
      harmony.PatchAll(Assembly.GetExecutingAssembly());
    }
  }
}
