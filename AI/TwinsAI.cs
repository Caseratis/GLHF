using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace GLHF.AI
{
    public class TwinsAI : GlobalNPC
    {
        bool rMad = false;
        bool sMad = false;
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }
        public override void AI(NPC npc)
        {
            if (npc.type == NPCID.Retinazer)
            {
                if (!NPC.npcsFoundForCheckActive[NPCID.Spazmatism] && rMad == false)
                {
                    rMad = true;
                    npc.life += npc.lifeMax / 2;
                }
            }

            if (npc.type == NPCID.Spazmatism)
            {
                if (!NPC.npcsFoundForCheckActive[NPCID.Retinazer] && sMad == false)
                {
                    sMad = true;
                    npc.life += npc.lifeMax / 2;
                }
            }
        }
    }
}