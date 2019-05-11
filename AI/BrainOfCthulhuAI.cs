using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace GLHF.AI
{
    public class BrainOfCthulhuAI : GlobalNPC
    {
        int cursedTimer;
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }

        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.Creeper)
            {
                npc.scale = 1.5f;
            }
        }
    }
}