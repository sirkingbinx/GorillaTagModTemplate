using BepInEx;
using GTModTemplate.Classes;
using GTModTemplate.Patches;
using GTModTemplate.Utilities;

namespace GTModTemplate;

[BepInPlugin(Constants.Name, Constants.Guid, Constants.Version)]
public class Plugin : BaseUnityPlugin
{
    public GorillaLog Log = new();

    private void Start()
    {
        HarmonyPatches.Patch();
        GorillaTagger.OnPlayerSpawned(() => MethodUtilities.Attempt(OnPlayerSpawned));
    }

    private void OnPlayerSpawned()
    {
        Log.WriteLine("Hello world!");
    }
}
