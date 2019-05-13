using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace GLHF
{
    public class MyPlayer : ModPlayer
    {
        public override void Hurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)
        {
            if (Main.rand.Next(3) == 0)
            {
                player.AddBuff(BuffID.Bleeding, 120, false);
            }
        }
    }
}
