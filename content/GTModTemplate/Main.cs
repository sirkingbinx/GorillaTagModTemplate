using GTModTemplate.Classes;
using GTModTemplate.Patches;
using GTModTemplate.Utilities;
using System;

namespace GTModTemplate;

public class Main : MonoBehaviour
{
    public static Main Instance;

    // This is a log, used for writing information for debug purposes
    public GorillaLog Log = new();

    // This is called when the mod initializes
    private void Start()
    {
        Instance = this;
        HarmonyPatches.Patch(); // Patch the game
        Config.Load(); // Load configuration data
        Application.quitting += Config.Save; // Save configuration on exit

        // Stops the OnPlayerSpawned method from creating unhandled errors, so other mods
        // can still work even if yours breaks.
        GorillaTagger.OnPlayerSpawned(() => MethodUtilities.Attempt(OnPlayerSpawned));
    }

    // This is called when everything is ready in the game before the gorilla is spawned into the world.
    private void OnPlayerSpawned()
    {
        // Write some text to the log file
        Log.WriteLine($"Hello world!");
    }
}
