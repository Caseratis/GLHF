using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace GLHF.AI
{
    public class FishronAI : GlobalNPC
    {
        int rainTimer;

        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }
        public override void AI(NPC npc)
        {
            

            if (npc.type == NPCID.DukeFishron)
            {
                rainTimer++;
                if (rainTimer == 15)
                {
                    rainTimer = 0;
                    Projectile.NewProjectile(npc.Center.X + Main.rand.Next(-(Main.screenWidth), (Main.screenWidth)), npc.Center.Y - 600, 0, 11, mod.ProjectileType("Rain"), 50, 1);
                }
            }

        }
    }
}