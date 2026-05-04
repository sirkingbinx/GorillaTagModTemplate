using BepInEx;
using UnityEngine;

namespace GTModTemplate;

// This is used by BepInEx to initialize your mod. Please put all of your mod code in Main.cs.

[BepInPlugin(Constants.Name, Constants.Guid, Constants.Version)]
public class PluginBepInEx : BepInPlugin
{
    private void Start()
    {
        GameObject obj = new GameObject(Constants.Guid)
        obj.AddComponent<Main>();
        DontDestroyOnLoad(obj);
    }
}
