using System.IO;
using BepInEx.Configuration;

namespace LongerDays_LC.Configuration
{
	internal static class Config
	{
		private const string CONFIG_FILE_NAME = "LongerDays_LC.cfg";

		private static ConfigFile _config;

		private static ConfigEntry<float> _lengthOfHoursMod;

		public static float LengthOfHoursMod
		{
			get
			{
				return _lengthOfHoursMod.Value;
			}
		}
		public static void Init()
		{
			LongerDays_LCPlugin.Log.LogMessage("Initializing config...");
			_config = new ConfigFile(Path.Combine(BepInEx.Paths.ConfigPath, "LongerDays_LC.cfg"), true);
			_lengthOfHoursMod = _config.Bind<float>("Config", "Length Of Hours Modifier", 100f, "Sets the modifier for determining length of an hour ingame.");
			LongerDays_LCPlugin.Log.LogMessage("Config initialized!");
		}

		private static void PrintConfig()
		{
			LongerDays_LCPlugin.Log.LogMessage($"Length Of Hours Modifier: {_lengthOfHoursMod.Value}");
		}
	}
}