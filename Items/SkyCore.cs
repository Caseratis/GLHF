using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GLHF.Items
{
    public class SkyCore : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sky Core");
            Tooltip.SetDefault("20% increased movement speed");
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
            player.moveSpeed += 1.2f;
        }
    }
}

