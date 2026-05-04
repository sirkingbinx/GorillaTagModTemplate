using BepInEx;
using UnityEngine;

namespace GTModTemplate;

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
