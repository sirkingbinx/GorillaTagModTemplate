using BepInEx;
using GTModTemplate.Classes;
using GTModTemplate.Patches;
using GTModTemplate.Utilities;

namespace GTModTemplate;

[BepInPlugin(Constants.Name, Constants.Guid, Constants.Version)]
public class Plugin : BaseUnityPlugin
{
    private void Start()
    {
        HarmonyPatches.Patch();
        GorillaTagger.OnPlayerSpawned(() => MethodUtilities.Attempt(OnPlayerSpawned));
    }

    private void OnPlayerSpawned()
    {
        Logger.WriteLine("Hello world!");
    }
}
