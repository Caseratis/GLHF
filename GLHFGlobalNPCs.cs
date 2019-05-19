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
        int spazTimer = 0;
        int skeletronLaserTimer = 0;
        int destroyerTimer = 0;
        int mistTimer = 0;

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
                npc.lifeMax += (int)(npc.lifeMax * .25);
            }

            if (Config.ScaleDefense == true)
            {
                npc.defense += (int)(npc.defense *.25);
            }

            if (Config.ScaleDamage == true)
            {
                npc.damage += (int)(npc.damage * .25);
            }

            if (Config.ScaleKnockback == true)
            {
                npc.knockBackResist *= .75f;

            }

            if (Config.TrapImmunity == true && !npc.townNPC)
            {

                npc.trapImmune = true;
            }

            if (Config.LavaImmunity == true && !npc.townNPC)
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

        public override void AI(NPC npc)
        {
            if (npc.type == NPCID.Retinazer)
            {
                int latestNPC = npc.whoAmI;
                if (!NPC.AnyNPCs(NPCID.Spazmatism))
                {

                    if (!NPC.AnyNPCs(mod.NPCType("MiniSpaz")))
                    {
                        Main.PlaySound(SoundID.Roar, (int)npc.position.X, (int)npc.position.Y, 0);
                        latestNPC = NPC.NewNPC((int)npc.Center.X / 2, (int)npc.Center.Y / 2, mod.NPCType("MiniSpaz"), npc.whoAmI, 0, latestNPC);
                        Main.npc[(int)latestNPC].ai[3] = npc.whoAmI;



                    }
                }

            }

                if (npc.type == NPCID.Spazmatism)
                {
                    int latestNPC = npc.whoAmI;
                    if (!NPC.AnyNPCs(NPCID.Retinazer))
                    {

                        if (!NPC.AnyNPCs(mod.NPCType("MiniRet")))
                        {
                        Main.PlaySound(SoundID.Roar, (int)npc.position.X, (int)npc.position.Y, 0);
                        latestNPC = NPC.NewNPC((int)npc.Center.X / 2, (int)npc.Center.Y / 2, mod.NPCType("MiniRet"), npc.whoAmI, 0, latestNPC);
                            Main.npc[(int)latestNPC].ai[3] = npc.whoAmI;



                        }
                    }
                }

                if (npc.type == NPCID.SkeletronPrime)
                {

                    if (!NPC.AnyNPCs(NPCID.PrimeCannon) && !NPC.AnyNPCs(NPCID.PrimeLaser) && !NPC.AnyNPCs(NPCID.PrimeVice) && !NPC.AnyNPCs(NPCID.PrimeSaw))
                    {
                        if (npc.ai[1] == 1)
                        {
                            skeletronLaserTimer++;
                            if (skeletronLaserTimer >= 10)
                            {
                                skeletronLaserTimer = 0;
                                Projectile.NewProjectile(npc.Center, new Vector2(5, 5).RotatedByRandom(MathHelper.ToRadians(360)), ProjectileID.DeathLaser, 25, 0); //Spawning a projectile
                            }
                        }
                    }
                }

                if (npc.type == NPCID.TheDestroyer)
                {
                    destroyerTimer++;
                    if (destroyerTimer >= 900)
                    {
                        destroyerTimer = 0;
                        Player P = Main.player[npc.target];
                        Projectile.NewProjectile(P.Center, new Vector2(0, 0), mod.ProjectileType("LaserStrike"), 0, 0, 0);
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
