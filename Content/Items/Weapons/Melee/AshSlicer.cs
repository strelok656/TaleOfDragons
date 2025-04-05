using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using ReLogic.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TaleOfDragons.Content.Items.Weapons.Melee
{
    public class AshSlicer : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = Item.height = 53;
            Item.scale = 1f; // Мультипликатор размера предметов. Важно: переменным с плавающей точкой, нужно добавлять "f" в конце.
            Item.rare = ItemRarityID.Blue; //Редкость. Смотри https://terraria.wiki.gg/wiki/Rarity
            Item.damage = 50; // Урон
            Item.DamageType = DamageClass.Melee; //Тип урона по классам: Melee, Ranged, Magic, Summon, Generic (берет бонусы от всех классов), Default (не берет никаких бонусов)
            // useTime и useAnimation часто имеют одинаковое значение
            Item.useTime = 20; //Длительность удара в тактах (60 тактов = 1 секунда)
            Item.useAnimation = 20; //Время анимации в тактах (60 тактов = 1 секунда)
            Item.knockBack = 6f; // Отбрасывание, 20 максимум
            Item.autoReuse = true;
            Item.value = 1000; // Цена в медных монетах
            Item.useStyle = ItemUseStyleID.Thrust; //Стиль анимации, смотри https://terraria.wiki.gg/wiki/Use_Style_IDs
            Item.UseSound = SoundID.Item1; // Издаваемый звук, смотри - https://terraria.wiki.gg/wiki/Sound_IDs
            
        }

        //Рецепт
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            //recipe.AddIngredient<CoolStar>(7); //Вот мой кастомный материал
            recipe.AddIngredient(ItemID.HellstoneBar, 10); // Адский слиток
            recipe.AddTile(TileID.Anvils); //Станция крафта, смотри - https://terraria.wiki.gg/wiki/Tile_IDs
            recipe.Register();
        }
    }
}