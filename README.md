# DISCLAIMER
I am abandoning this repository as I found one that works better. See https://thunderstore.io/c/lethal-company/p/IsCoffeeTho/LethalDays/

# LongerDays_LC
A mod for Lethal Company which extends the length of each day. You can change the length for each day by updating the config file generated after the first initial run.

## Development Setup

- Clone the repo [LongerDays_LC](https://github.com/RaspberryProgramming/LongerDays_LC)
- You'll need to install [Visual Studio](https://visualstudio.microsoft.com/) and [.Net Framework 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472)
- Next, you'll need to create a new folder called Dependencies in the root of the github project folder and copy the following files from your lethal company's folder. common\Lethal Company\Lethal Company_Data\Managed
  - Assembly-CSharp-firstpass.dll
  - Assembly-CSharp.dll
  - Unity.Netcode.Runtime.dll
- Open the project solution in visual studio
- Add a new file to the project called GameDirectory.targets and fill it with a file like the following. Ensure that the GameDirectory is correct for your locally installed game directory.
```xml
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
    <!-- Note: Do not commit this file into version control (git). The whole point of having this file separate is so that you can -->
    <!-- have your IDE do all this extra work *without* broadcasting the contents of your filesystem to the entire world. -->
    <PropertyGroup>
        <GameDirectory>C:\Program Files (x86)\Steam\steamapps\common\Lethal Company</GameDirectory>
        <!-- Optionally, you can also define a more convenient release folder for all your zip files to get stored in. -->
        <!-- <ReleaseZipDirectory>$(SolutionDir)\Releases</ReleaseZipDirectory> -->
    </PropertyGroup>
</Project>
```

## Installation

- Install [BepInEx](https://thunderstore.io/c/lethal-company/p/BepInEx/BepInExPack/)
- Unzip this mod into your `Lethal Company/BepInEx` folder

Or use the thunderstore mod manager to handle the installing for you.

After your first run you can modify the config from thunderstore mod manager or from in your lethalcompany steam folder. The vanilla modifier will be default.
