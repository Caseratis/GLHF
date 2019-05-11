using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GLHF.Items
{
    public class JungleCore : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jungle Core");
            Tooltip.SetDefault("10% increased ranged damage and crit chance");
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
            player.rangedDamage *= 1.1f;
            player.rangedCrit += player.rangedCrit/10;
        }
    }
}

