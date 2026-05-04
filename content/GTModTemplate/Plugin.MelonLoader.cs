using BepInEx;
using MelonLoader;
using GTModTemplate;

// This is used by MelonLoader to initialize your mod. Please put all of your mod code in Main.cs.

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
