﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GLHF.Items
{
    public class UndergroundCore : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Underground Core");
            Tooltip.SetDefault("+100 max life");
        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 34;
            item.value = 1000000;
            item.rare = 1;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statLifeMax2 += 100;
        }
    }
}

