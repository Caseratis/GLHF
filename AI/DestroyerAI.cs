using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace GLHF.AI
{
    public class DestroyerAI : GlobalNPC
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
            if (npc.type == NPCID.TheDestroyer)
            {
                npc.scale = 2.5f;
                npc.damage *= 2;
            }

            if (npc.type == NPCID.TheDestroyerBody || npc.type == NPCID.TheDestroyerTail)
            {
                npc.scale = 2.5f;
            }

            if (npc.type == NPCID.Probe)
            {
                npc.scale = 2.5f;
               
            }
        }
    }
}