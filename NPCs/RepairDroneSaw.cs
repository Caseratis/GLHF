using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GLHF.NPCs
{
    public class RepairDroneSaw : ModNPC
    {
        float speed;
        int shootTimer;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Repair Drone");
        }

        public override void SetDefaults()
        {
            npc.width = 36;
            npc.height = 60;
            npc.damage = 60;
            npc.defense = 3;
            npc.lifeMax = 100;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath6;
            npc.value = 500f;
            npc.knockBackResist = 0f;
            npc.aiStyle = 2;
            npc.noTileCollide = true;
            npc.scale = .75f;
        }

        public override void AI()
        {
            Player P = Main.player[npc.target]; // Player targeting
            Vector2 moveTo = NPC. + new Vector2(0f, 0f);
            // Movement
            speed = 5;

            Vector2 move = moveTo - npc.Center; //this is how much your boss wants to move
            float magnitude = (float)Math.Sqrt(move.X * move.X + move.Y * move.Y); //fun with the Pythagorean Theorem
            move *= speed / magnitude; //this adjusts your boss's speed so that its speed is always constant
            npc.velocity = move;

            shootTimer++;
            float Speed = 10;
            Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
            float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
            if (shootTimer == 100)
            {
                shootTimer = 0;
                Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), ProjectileID.EyeLaser, 15, 0f, 0);
            }

            

        }


        
    }
}