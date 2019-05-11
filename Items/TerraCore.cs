using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GLHF.Items
{
    public class TerraCore : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Terra Core");
            Tooltip.SetDefault("A stronger version of all the materials used.");
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
            player.statLifeMax2 += 150;
            player.statDefense += 15;
            player.meleeDamage *= 1.2f;
            player.meleeSpeed *= 1.2f;
            player.meleeCrit += player.meleeCrit / 4;
            player.magicDamage *= 1.2f;
            player.statManaMax2 += 100;
            player.magicCrit += player.magicCrit / 4;
            player.minionDamage *= 1.2f;
            player.maxMinions += 3;
            player.rangedDamage *= 1.2f;
            player.rangedCrit += player.rangedCrit / 4;
            player.thrownDamage *= 1.2f;
            player.thrownVelocity *= 1.2f;
            player.thrownCrit += player.thrownCrit / 4;
            player.lifeRegen += 10;
            player.moveSpeed *= 1.3f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SurfaceCore"));
            recipe.AddIngredient(mod.ItemType("UndergroundCore"));
            recipe.AddIngredient(mod.ItemType("DesertCore"));
            recipe.AddIngredient(mod.ItemType("SnowCore"));
            recipe.AddIngredient(mod.ItemType("CorruptCore"));
            recipe.AddIngredient(mod.ItemType("SkyCore"));
            recipe.AddIngredient(mod.ItemType("JungleCore"));
            recipe.AddIngredient(mod.ItemType("OceanCore"));
            recipe.AddIngredient(mod.ItemType("HellCore"));
            recipe.AddIngredient(mod.ItemType("HallowCore"));
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SurfaceCore"));
            recipe.AddIngredient(mod.ItemType("UndergroundCore"));
            recipe.AddIngredient(mod.ItemType("DesertCore"));
            recipe.AddIngredient(mod.ItemType("SnowCore"));
            recipe.AddIngredient(mod.ItemType("BloodCore"));
            recipe.AddIngredient(mod.ItemType("SkyCore"));
            recipe.AddIngredient(mod.ItemType("JungleCore"));
            recipe.AddIngredient(mod.ItemType("OceanCore"));
            recipe.AddIngredient(mod.ItemType("HellCore"));
            recipe.AddIngredient(mod.ItemType("HallowCore"));
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

