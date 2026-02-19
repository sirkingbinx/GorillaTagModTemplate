using System;
using BepInEx;
using GTModTemplate.Patches;

namespace GTModTemplate;
//Example dependency - can also include version numbers
//[BepInDependency("example.mod.guid")]

// See Constants.cs to edit these arguments
[BepInPlugin(Constants.Guid, Constants.Name, Constants.Version)]
public class Main : BaseUnityPlugin
{
    //static instance means it can be accessed anywhere
    public static Main? Instance;

    public Main() // we want these ASAP, this is a Constructor
    {
        Instance = this;
        HarmonyPatches.Patch();
    }

    //You only need to have things run when your player spawns expect asset loading, do that Async
    private void Start()
    {
        GorillaTagger.OnPlayerSpawned(OnPlayerSpawn);
    }

    // The starting point of the mod. This method is called when the Player is Spawned
    private void OnPlayerSpawn()
    {
        //"try catch" so we don't brick the player if we mess up
        try
        {
            //Code startup code here


            //Keep this at the end so we know we have finished
            Logger.LogInfo($"[{Constants.Name}] I have loaded!");
        }
        catch (Exception e)
        {
            //This is the correct way to log for a Bepinex mod, you can use the instance to log in other classes
            Logger.LogError($"[{Constants.Name}] Player Start Failed:{e.Message + e.StackTrace}");
        }
    }
}
