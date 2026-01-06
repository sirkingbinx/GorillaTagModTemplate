using GorillaTagModTemplate.Patches;
using BepInEx;
using UnityEngine;

namespace GorillaTagModTemplate;

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
        
        GorillaTagger.OnPlayerSpawned(OnPlayerSpawned);
    }

    // This method is called when the player spawns into the world.
    private void OnPlayerSpawned()
    {
        Debug.Log("Hello world");
    }
}
