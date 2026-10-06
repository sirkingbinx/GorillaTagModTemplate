using BepInEx;
using GTModTemplate.Patches;
using GTModTemplate.Utilities;

namespace GTModTemplate;

[BepInPlugin(Constants.Guid, Constants.Name, Constants.Version)]
public class Plugin : BaseUnityPlugin
{
    private void Start()
    {
        HarmonyPatches.Patch();
        GorillaTagger.OnPlayerSpawned(() => MethodUtilities.Attempt(OnPlayerSpawned));
    }

    private void OnPlayerSpawned()
    {
        Logger.WriteInfo("Hello world!");
    }
}
