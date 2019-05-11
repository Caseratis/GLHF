using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace GLHF.AI
{
    public class SkeletronPrimeAI : GlobalNPC
    {
        int laserTimer;

        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }
        public override void AI(NPC npc)
        {

            if (npc.type == NPCID.SkeletronPrime)
            {
                laserTimer++;
                float Speed = 15;
                Player P = Main.player[npc.target];
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                if (laserTimer == 100)
                {
                    laserTimer = 0;
                    Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), ProjectileID.DeathLaser, 15, 0f, 0);
                }
            }
        }
    }
}