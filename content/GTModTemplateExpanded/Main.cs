using GTModTemplateExpanded.Patches;
using GTModTemplateExpanded.Utilities;
using BepInEx;
using UnityEngine;

namespace GTModTemplateExpanded;

// See Constants.cs to edit these arguments
[BepInPlugin(Constants.Guid, Constants.Name, Constants.Version)]
public class Main : BaseUnityPlugin
{
    public static Main? Instance;

    // The starting point of the mod. This methodd is called when the mod is loaded.
    private void Start()
    {
        Instance ??= this;
        HarmonyPatches.Patch();
        
        // Here is the spot to load any Asset Bundles in your program.

        // MethodUtilities.Attempt is a wrapper for the try block, we use it
        // here to prevent your mod from breaking every other mod in the case
        // that your OnPlayerSpawned() method causes errors.
        GorillaTagger.OnPlayerSpawned(() => MethodUtilities.Attempt(OnPlayerSpawned));
        
        // This would be the spot to unload all of your AssetBundles when your
        // assets have been loaded in. Save some memory!
        AssetBundleUtilities.FreeCache();
    }

    // This method is called when the player spawns into the world.
    private void OnPlayerSpawned()
    {
        Debug.Log("Hello world");
    }
}
