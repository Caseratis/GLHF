using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace GLHF
{
    public class GLHFGlobalNPC : GlobalNPC
    {
        int NPCLifeRegenTimer;

        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }

        public override void SetDefaults(NPC npc)
        {
            if (Config.ScaleHealth == true)
            {
                npc.lifeMax += npc.lifeMax / 2;
            }

            if (Config.ScaleDefense == true)
            {
                npc.defense += npc.defense / 2;
            }

            if (Config.ScaleDamage == true)
            {
                npc.damage += npc.damage / 2;
            }

            if (Config.ScaleKnockback == true)
            {
                npc.knockBackResist *= 1.5f;

            }

            if (Config.TrapImmunity == true)
            {

                npc.trapImmune = true;
            }

            if (Config.LavaImmunity == true)
            {
                npc.lavaImmune = true;
            }
               

            npc.value *= 1.5f;

        }

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (Config.LifeRegen == true)
            {
                if (!Main.hardMode)
                {
                    npc.lifeRegen += 2;
                }
                if (Main.hardMode)
                {
                    npc.lifeRegen += 6;
                }
            }

        }

        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {

            if (Config.ScaleSpawnrates == true)
            {
                if (!Main.hardMode)
                {
                    spawnRate = (spawnRate *= 2);
                    maxSpawns = (maxSpawns *= 2);
                }

                if (Main.hardMode)
                {
                    spawnRate = (spawnRate *= 3);
                    maxSpawns = (maxSpawns *= 3);
                }
            }

        }

        

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public override void NPCLoot(NPC npc)
        {
            int CoreChance = new Random().Next(0, 500);
            if (CoreChance == 0 && npc.lifeMax > 5 && npc.value > 0f)
            {
                if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneOverworldHeight && Main.hardMode)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SurfaceCore"));
                }
            }

            if (CoreChance == 0 && npc.lifeMax > 5 && npc.value > 0f)
            {
                if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCrimson && Main.hardMode)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BloodCore"));
                }
            }

            if (CoreChance == 0 && npc.lifeMax > 5 && npc.value > 0f)
            {
                if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCorrupt && Main.hardMode)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CorruptCore"));
                }
            }

            if (CoreChance == 0 && npc.lifeMax > 5 && npc.value > 0f)
            {
                if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneDesert && Main.hardMode)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DesertCore"));
                }
            }

            if (CoreChance == 0 && npc.lifeMax > 5 && npc.value > 0f)
            {
                if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneHoly && Main.hardMode)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HallowCore"));
                }
            }

            if (CoreChance == 0 && npc.lifeMax > 5 && npc.value > 0f)
            {
                if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneUnderworldHeight && Main.hardMode)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HellCore"));
                }
            }

            if (CoreChance == 0 && npc.lifeMax > 5 && npc.value > 0f)
            {
                if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneJungle && Main.hardMode)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("JungleCore"));
                }
            }

            if (CoreChance == 0 && npc.lifeMax > 5 && npc.value > 0f)
            {
                if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneBeach && Main.hardMode)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("OceanCore"));
                }
            }

            if (CoreChance == 0 && npc.lifeMax > 5 && npc.value > 0f)
            {
                if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneSkyHeight && Main.hardMode)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SkyCore"));
                }
            }

            if (CoreChance == 0 && npc.lifeMax > 5 && npc.value > 0f)
            {
                if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneSnow && Main.hardMode)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SnowCore"));
                }
            }

            if (CoreChance == 0 && npc.lifeMax > 5 && npc.value > 0f)
            {
                if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneRockLayerHeight && Main.hardMode)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("UndergroundCore"));
                }
            }
        }
    }
}
