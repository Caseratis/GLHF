using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace GLHF.AI
{
    public class QueenBeeAI : GlobalNPC
    {
        int beeTimer;

        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }
        public override void AI(NPC npc)
        {
            
            if (npc.type == NPCID.QueenBee)
            {
                beeTimer++;
                if (beeTimer == 500)
                {
                    beeTimer = 0;
                    Projectile.NewProjectile(npc.Center.X, npc.Center.Y, 0f, 0f, ProjectileID.BeeHive, 0, 0, Main.myPlayer);
                }
            }
        }
    }
}