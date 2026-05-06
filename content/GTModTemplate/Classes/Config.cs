using System.IO;
using Newtonsoft.Json;
using UnityEngine;

namespace GTModTemplate.Classes;

/// <summary>
/// Class for working with configuration.
/// </summary>
public class Config
{
    /// <summary>
    /// This is where the current configuration is saved.
    /// </summary>
    public static Config Current = new();

    // Each config option should be a public non-static variable.
    // See below for examples:
    // 
    // public string TestValue1 = "this is the default value";
    // public int TestValue2 = 0;
    // public List<string> TestValue3 = ["list", "of", "items"];
    // 

    public static void Save()
    {
        var dataPath = Path.Combine(Application.persistentDataPath, Constants.Name);
        Directory.CreateDirectory(dataPath);

        var fileName = Path.Combine(dataPath, "config.json");
        var json = JsonConvert.SerializeObject(Current);

        File.WriteAllText(fileName, json);
    }

    public static void Load()
    {
        var dataPath = Path.Combine(Application.persistentDataPath, Constants.Name);
        Directory.CreateDirectory(dataPath);
        var fileName = Path.Combine(dataPath, "config.json");

        if (!File.Exists(fileName))
            return;

        var json = File.ReadAllText(fileName);

#pragma warning disable CS8601
        try {
            Current = JsonConvert.DeserializeObject<Config>(json);
        } catch { } // skip any errors we get
#pragma warning restore CS8601
    }
}