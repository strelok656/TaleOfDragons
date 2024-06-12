using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace Test.Content.Items.Materials { 
	public class CoolStar : ModItem {
		public override void SetStaticDefaults() {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}

		public override void SetDefaults() {
			Item.width = Item.height = 32;
			Item.maxStack = 9999; 
			Item.value = 100;
			Item.rare = ItemRarityID.Green; 
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FallenStar,1); // Звезда
			recipe.AddIngredient(ItemID.CrimtaneOre,3); // Кримтановая руда
			recipe.AddTile(TileID.Anvils); // Наковальня
			recipe.Register();
		}
	}
}