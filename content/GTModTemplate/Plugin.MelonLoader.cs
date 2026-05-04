using BepInEx;
using MelonLoader;
using GTModTemplate;

[assembly: MelonInfo(typeof(PluginMelonLoader), GTModTemplate.Constants.Name, GTModTemplate.Constants.Version, GTModTemplate.Constants.Author)]
[assembly: MelonGame("Another Axiom", "Gorilla Tag")]
[assembly: HarmonyDontPatchAll]

namespace GTModTemplate;

public class PluginMelonLoader : MelonMod
{
    public override void OnLateInitializeMelon()
    {
        GameObject obj = new GameObject(Constants.Guid)
        obj.AddComponent<Main>();
        Object.DontDestroyOnLoad(obj);
    }
}
