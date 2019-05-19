using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GLHF.NPCs
{
    public class MiniSpaz : ModNPC
    {
        int shootTimer;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mini Spazmitism");     //The English name of the npc
        }

        public override void SetDefaults()
        {
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 100;
            npc.value = 0f;
            npc.knockBackResist = 0f;
            npc.aiStyle = 0;
            npc.noTileCollide = true;
            npc.alpha = 150;
            npc.dontTakeDamage = true;
            npc.scale = 1.25f;
        }

        public override void AI()
        {
            if (!NPC.AnyNPCs(NPCID.Retinazer))
            {
                npc.life = 0;
            }

            float Speed = 15;
            Player P = Main.player[npc.target];
            Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
            float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));

            npc.spriteDirection = 1;
            npc.rotation = rotation;

            if (Collision.CanHit(npc.position, npc.width, npc.height, Main.player[npc.target].position, Main.player[npc.target].width, Main.player[npc.target].height))
            {
                shootTimer++;

                
                if (shootTimer >= Main.rand.Next(180, 300))
                {
                    shootTimer = 0;
                    Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), ProjectileID.CursedFlameHostile, 20, 0f, 0);
                }
            }
            
            //Making npc variable "n" set as the npc's owner
            NPC n = Main.npc[(int)npc.ai[3]];
            //Player n = Main.player[npc.target];
            //Factors for calculations
            double deg = (double)npc.ai[1]; //The degrees, you can multiply npc.ai[1] to make it orbit faster, may be choppy depending on the value
            double rad = deg * (Math.PI / 180); //Convert degrees to radians
            double dist = 100; //Distance away from the player

            /*Position the player based on where the player is, the Sin/Cos of the angle times the /
            /distance for the desired distance away from the player minus the npc's width   /
            /and height divided by two so the center of the npc is at the right place.     */
            npc.position.X = n.Center.X - (int)(Math.Cos(rad) * dist) - npc.width / 2;
            npc.position.Y = n.Center.Y - (int)(Math.Sin(rad) * dist) - npc.height / 2;

            //Increase the counter/angle in degrees by 1 point, you can change the rate here too, but the orbit may look choppy depending on the value
            npc.ai[1] += 3f;

            
        }


    }
}