/*
 * Hey all, welcome to the mod template I use for like everything :)
 * It contains many utilities to start working on mods without the need to setup anything.
 *
 * Browse through the included directories to see what you have to work with.
 * The methods commented below in the code are significant.
 *
 *      - Bingus
*/

using GTModTemplate.Patches;
using GTModTemplate.Utilities;
using BepInEx;
using UnityEngine;

namespace GTModTemplate;

// See Constants.cs to edit these arguments
[BepInPlugin(Constants.Guid, Constants.Name, Constants.Version)]
public class Main : BaseUnityPlugin
{
    public static Main? Instance;

    // The starting point of the mod. This methodd is called when the mod is loaded.
    private void Start()
    {
        Instance = this;
        HarmonyPatches.Patch();
        
        // Here is the spot to load any Asset Bundles in your program.
        GorillaTagger.OnPlayerSpawned(() => MethodUtilities.Attempt(OnPlayerSpawned));
        
        // This would be the spot to unload all of your AssetBundles when your
        // assets have been loaded in.
        // Save memory!
        AssetBundleUtilities.FreeCache();
    }

    // This method is called when the player spawns into the world.
    private void OnPlayerSpawned()
    {
        Debug.Log("Hello world");
    }
}