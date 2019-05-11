using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GLHF.Items
{
    public class SnowCore : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Snow Core");
            Tooltip.SetDefault("10% increased mimion damage and +2 minion slots");
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
            player.minionDamage *= 1.1f;
            player.maxMinions += 2;
        }
    }
}

