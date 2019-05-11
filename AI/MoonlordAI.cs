using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace GLHF.AI
{
    public class MoonlordAI : GlobalNPC
    {
        int moonTimer;

        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }
        public override void AI(NPC npc)
        {


            if (npc.type == NPCID.MoonLordCore)
            {
                moonTimer++;
                float Speed = 10;
                Player P = Main.player[npc.target];
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                int moonAttack = Main.rand.Next(0, 4);
                if (npc.life >= npc.lifeMax / 2)
                {
                    if (moonTimer == 300 && moonAttack == 0)
                    {
                        moonTimer = 0;
                        Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), ProjectileID.CultistBossFireBall, 100, 0f, 0);
                    }

                    if (moonTimer == 300 && moonAttack == 1)
                    {
                        moonTimer = 0;
                        Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), ProjectileID.CultistBossIceMist, 100, 0f, 0);
                    }

                    if (moonTimer == 300 && moonAttack == 2)
                    {
                        moonTimer = 0;
                        Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), ProjectileID.CultistBossLightningOrb, 100, 0f, 0);
                    }

                    if (moonTimer == 300 && moonAttack == 3)
                    {
                        moonTimer = 0;
                        Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), ProjectileID.CultistBossFireBallClone, 100, 0f, 0);
                    }

                }

                if (npc.life <= npc.lifeMax / 2)
                {
                    if (moonTimer == 150 && moonAttack == 0)
                    {
                        moonTimer = 0;
                        Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), ProjectileID.CultistBossFireBall, 100, 0f, 0);
                    }

                    if (moonTimer == 150 && moonAttack == 1)
                    {
                        moonTimer = 0;
                        Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), ProjectileID.CultistBossIceMist, 100, 0f, 0);
                    }

                    if (moonTimer == 150 && moonAttack == 2)
                    {
                        moonTimer = 0;
                        Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), ProjectileID.CultistBossLightningOrb, 100, 0f, 0);
                    }

                    if (moonTimer == 150 && moonAttack == 3)
                    {
                        moonTimer = 0;
                        Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), ProjectileID.CultistBossFireBallClone, 100, 0f, 0);
                    }
                }

            }

        }
    }
}