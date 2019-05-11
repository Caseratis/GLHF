using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GLHF.Items
{
    public class CorruptCore : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Corrupt Core");
            Tooltip.SetDefault("10% increased melee damage, speed, and crit chance");
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
            player.meleeDamage *= 1.1f;
            player.meleeSpeed *= 1.1f;
            player.meleeCrit += player.meleeCrit/10;
        }
    }
}

