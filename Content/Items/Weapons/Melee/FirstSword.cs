using Test.Content.Items.Materials; // Используем наш материал
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace Test.Content.Items.Weapons.Melee
{
    public class FirstSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.scale = 1f; // Мультипликатор размера предметов. Важно: переменным с плавающей точкой, нужно добавлять "f" в конце.
            Item.rare = ItemRarityID.Blue; //Редкость. Смотри https://terraria.wiki.gg/wiki/Rarity
            Item.damage = 50; // Урон
            Item.DamageType = DamageClass.Melee; //Тип урона по классам: Melee, Ranged, Magic, Summon, Generic (берет бонусы от всех классов), Default (не берет никаких бонусов)
            // useTime и useAnimation часто имеют одинаковое значение
            Item.useTime = 20; //Длительность удара в тактах (60 тактов = 1 секунда)
            Item.useAnimation = 20; //Время анимации в тактах (60 тактов = 1 секунда)
            Item.knockBack = 6f; // Отбрасывание, 20 максимум
            Item.autoReuse = true; //Автоматическое использование
            Item.value = 1000; // Цена в медных монетах
            Item.useStyle = ItemUseStyleID.Swing; //Стиль анимации, смотри https://terraria.wiki.gg/wiki/Use_Style_IDs
            Item.UseSound = SoundID.Item1; // Издаваемый звук, смотри - https://terraria.wiki.gg/wiki/Sound_IDs
        }

        //Рецепт
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<CoolStar>(7); //Вот мой кастомный материал
            recipe.AddIngredient(ItemID.CrimtaneBar, 3); // Кримтановый слиток
            recipe.AddTile(TileID.Anvils); //Станция крафта, смотри - https://terraria.wiki.gg/wiki/Tile_IDs
            recipe.Register();
        }

    }
}