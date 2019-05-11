using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GLHF.Projectiles
{
    public class Rain : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rain");
        }

        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 30;
            projectile.timeLeft = 1200;
            projectile.penetrate = 3;
            projectile.hostile = true;
            projectile.magic = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.aiStyle = 1;
            projectile.scale = 2;
        }
    }
}