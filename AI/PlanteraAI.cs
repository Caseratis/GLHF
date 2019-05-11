using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace GLHF.AI
{
    public class PlanteraAI : GlobalNPC
    {

        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }

        public override void OnHitByProjectile(NPC npc, Projectile projectile, int damage, float knockback, bool crit)
        {
            if (npc.type == NPCID.PlanterasTentacle)
            {
                projectile.Kill();
            }
        }
    }
}