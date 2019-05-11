using Terraria.ID;
using Terraria.ModLoader;

namespace GLHF.Items
{
    public class DevGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Pew Pew");
        }

        public override void SetDefaults()
        {
            item.damage = 1000;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = ProjectileID.ChargedBlasterOrb;
            item.shootSpeed = 50f;
        }

    }
}
