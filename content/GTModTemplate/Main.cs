using BepInEx;
using GTModTemplate.Classes;
using GTModTemplate.Patches;
using GTModTemplate.Utilities;
using System;

namespace GTModTemplate;

public class Main : MonoBehaviour
{
    public static Main Instance;
    public LogFile Log = new();

    // This is called when the mod initializes
    private void Start()
    {
        Instance = this;
        GorillaTagger.OnPlayerSpawned(MethodUtilities.Attempt(OnPlayerSpawned));
    }

    private void OnPlayerSpawned()
    {
        Log.WriteLine($"Hello world!");
    }
}
