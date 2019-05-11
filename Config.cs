using System;
using System.IO;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;

public static class Config
{

    public static bool ScaleHealth = true;
    public static bool ScaleDefense = true;
    public static bool ScaleDamage = true;
    public static bool ScaleKnockback = true;
    public static bool ScaleValue = true;
    public static bool ScaleSpawnrates = true;
    public static bool LavaImmunity = true;
    public static bool TrapImmunity = true;
    public static bool LifeRegen = true;


    private static string ConfigPath = Path.Combine(Main.SavePath, "Mod Configs", "GLHFConfig.json");

    private static Preferences Configuration = new Preferences(Config.ConfigPath, false, false);

    public static void Load()
    {
        if (!Config.ReadConfig())
        {
            ErrorLogger.Log("Failed to read Loot Bag config file! Recreating config...");
            Config.CreateConfig();
        }
    }

    private static bool ReadConfig()
    {
        bool result;
        if (Config.Configuration.Load())
        {
            Config.Configuration.Get<bool>("ScaleHealth", ref Config.ScaleHealth);
            Config.Configuration.Get<bool>("ScaleDefense", ref Config.ScaleDefense);
            Config.Configuration.Get<bool>("ScaleDamage", ref Config.ScaleDamage);
            Config.Configuration.Get<bool>("ScaleKnockback", ref Config.ScaleKnockback);
            Config.Configuration.Get<bool>("ScaleValue", ref Config.ScaleValue);
            Config.Configuration.Get<bool>("ScaleSpawnrates", ref Config.ScaleSpawnrates);
            Config.Configuration.Get<bool>("LavaImmunity", ref Config.LavaImmunity);
            Config.Configuration.Get<bool>("TrapImmunity", ref Config.TrapImmunity);
            Config.Configuration.Get<bool>("LifeRegen", ref Config.LifeRegen);
            result = true;
        }
        else
        {
            result = false;
        }
        return result;
    }

    private static void CreateConfig()
    {
        Config.Configuration.Clear();
        Config.Configuration.Put("ScaleHealth (Set to false if some npc ai get messed up from health scaling)", Config.ScaleHealth);
        Config.Configuration.Put("ScaleDefense", Config.ScaleDefense);
        Config.Configuration.Put("ScaleDamage", Config.ScaleDamage);
        Config.Configuration.Put("ScaleKnockback", Config.ScaleKnockback);
        Config.Configuration.Put("ScaleValue", Config.ScaleValue);
        Config.Configuration.Put("ScaleSpawnrates", Config.ScaleSpawnrates);
        Config.Configuration.Put("LavaImmunity", Config.LavaImmunity);
        Config.Configuration.Put("TrapImmunity", Config.TrapImmunity);
        Config.Configuration.Put("LifeRegen", Config.LifeRegen);
        Config.Configuration.Save(true);
    }
}
