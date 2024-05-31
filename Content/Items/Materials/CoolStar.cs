using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.GameContent.Creative;

namespace Test.Content.Items.Materials { //Здесь расположен код
	public class CoolStar : ModItem {
		public override void SetStaticDefaults() {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10; //Кол-во предметов для открытия копирования в режиме приключения
		}

		public override void SetDefaults() {
			Item.width = 32; //Ширина спрайта
			Item.height = 32; //Высота спрайта
			Item.maxStack = 9999; //Максимальное кол-во предметов в ячейке
			Item.value = 100; //Цена в медных монетах
			Item.rare = ItemRarityID.Green; //Редкость
		}

		public override void AddRecipes() { //Рецепт
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FallenStar,1); //Звезда 75
			recipe.AddIngredient(ItemID.CrimtaneOre,3); //Кримтановая руда
			recipe.AddTile(TileID.Anvils); //На наковальне
			recipe.Register();
		}
	}
}