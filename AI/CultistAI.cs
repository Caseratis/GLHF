using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace GLHF.AI
{
    public class CultistAI : GlobalNPC
    {
        int summonTimer;
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }
        public override void AI(NPC npc)
        {
            

            if (npc.type == NPCID.CultistBoss)
            {
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                summonTimer++;
                if (summonTimer == 600)
                {
                    summonTimer = 0;
                    NPC.NewNPC((int)npc.position.X + (npc.width/2), (int)npc.position.Y + (npc.height/2), mod.NPCType("ShadowCultist"));
                }
            }

        }
    }
}