using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GLHF.Projectiles
{
    public class LaserStrike : ModProjectile
    {
        int laserTimer;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Target");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.width = 64;
            projectile.height = 64;
            projectile.friendly = false;
            projectile.hostile = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 360;
            projectile.tileCollide = false;
        }

        public override void AI()
        {
            if (projectile.timeLeft <= 180)
            {
                laserTimer++;
                if (Main.rand.NextFloat() < 1f)
                {
                    Dust dust;
                    // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
                    Vector2 position = projectile.Center + new Vector2(-50, -1250);
                    dust = Main.dust[Terraria.Dust.NewDust(position, 100, 0, 114, 0f, 0f, 0, new Color(255, 0, 0), 1f)];
                    dust.noGravity = true;
                    dust.fadeIn = 1f;
                }
                if (laserTimer >= 3)
                {
                    laserTimer = 0;
                    Projectile.NewProjectile(projectile.Center.X + Main.rand.Next(-50, 50), projectile.Center.Y - 1250, 0, 20, ProjectileID.DeathLaser, 20, 0);
                }
            }
        }
    }
}