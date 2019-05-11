using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace GLHF.AI
{
    public class EaterOfWorldsAI : GlobalNPC
    {
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }

        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.EaterofWorldsHead)
            {
                npc.scale = 2;
            }
        }
    }
}