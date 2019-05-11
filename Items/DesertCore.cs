using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GLHF.Items
{
    public class DesertCore : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Desert Core");
            Tooltip.SetDefault("10% increased throwing damage, velocity and crit chance ");
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
            player.thrownDamage *= 1.1f;
            player.thrownVelocity *= 1.1f;
            player.thrownCrit += player.thrownCrit / 10;
        }
    }
}

