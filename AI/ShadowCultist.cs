using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GLHF.AI
{
    public class ShadowCultist : ModNPC
    {

        public bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Clone");
            Main.npcFrameCount[npc.type] = 3;
        }

        public override void SetDefaults()
        {
            npc.width = 50;
            npc.height = 50;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 500;
            npc.value = 0f;
            npc.knockBackResist = 0f;
            npc.noGravity = true;
            npc.alpha = 100;
        }

        public override void AI()
        {

            npc.ai[0]++;
            float Speed = 10;
            Player P = Main.player[npc.target];
            Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
            float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
            int cultistAttack = Main.rand.Next(0, 4);

            if (npc.ai[0] == 300 && cultistAttack == 0)
            {
                npc.ai[0] = 0;
                Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), ProjectileID.CultistBossFireBall, 50, 0f, 0);
            }

            if (npc.ai[0] == 300 && cultistAttack == 1)
            {
                npc.ai[0] = 0;
                Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), ProjectileID.CultistBossIceMist, 50, 0f, 0, 0f, 1f);
            }

            if (npc.ai[0] == 300 && cultistAttack == 2)
            {
                npc.ai[0] = 0;
                Projectile.NewProjectile(vector8.X, vector8.Y - 100, 0, 0, ProjectileID.CultistBossLightningOrb, 50, 0f, 0);
            }

            if (npc.ai[0] == 300 && cultistAttack == 3)
            {
                npc.ai[0] = 0;
                Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), ProjectileID.CultistBossFireBallClone, 50, 0f, 0);
            }
        }
    }
}