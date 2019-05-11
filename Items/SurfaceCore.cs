using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GLHF.Items
{
    public class SurfaceCore : ModItem
    { 

    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Surface Core");
        Tooltip.SetDefault("Minor increased stats");
    }

    public override void SetDefaults()
    {
        item.width = 34;
        item.height = 34;
        item.value = 1000000;
        item.rare = 1;
        item.accessory = true;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
                player.statLifeMax2 += 50;
                player.statDefense += 7;
                player.meleeDamage *= 1.07f;
                player.magicDamage *= 1.07f;
                player.minionDamage *= 1.07f;
                player.rangedDamage *= 1.07f;
                player.thrownDamage *= 1.07f;
                player.lifeRegen += 4;
                player.moveSpeed *= 1.1f;
    }
}
}

