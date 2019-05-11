using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GLHF.Items
{
    public class HallowCore : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hallow Core");
            Tooltip.SetDefault("10% increased magic damage and magic crit chance and +50 max mana");
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
            player.magicDamage *= 1.1f;
            player.statManaMax2 += 50;
            player.magicCrit += player.magicCrit / 10;
        }
    }
}

