using Godot.Bridge;
using HarmonyLib;
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Modding;

namespace Pokemon.Scripts;

// Required attribute for mod registration. The string must match your init function name.
[ModInitializer(nameof(Init))]
public class Entry
{
    // Initialization function
    public static void Init()
    {
        // For patching (modifying game code)
        // Pick any ID that won't collide with others
        var harmony = new Harmony("sts2.reme.testmod");
        harmony.PatchAll();
        // Allows tscn files to load custom scripts
        ScriptManagerBridge.LookupScriptsInAssembly(typeof(Entry).Assembly);
        Log.Info("Mod initialized!");
    }
}
