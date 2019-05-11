using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GLHF.Projectiles
{
    public class Tears : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tears");
        }

        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.height = 18;
            projectile.timeLeft = 10000;
            projectile.penetrate = 3;
            projectile.hostile = true;
            projectile.magic = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.aiStyle = 1;
            projectile.scale = 2;
        }

        public override void AI()
        {
            {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("TearDust"));
                Main.dust[dust].velocity /= 2f;
            }
        }
    }
}