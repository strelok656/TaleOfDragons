using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Test.Content.Items.Materials;
using Test.Content.Projectiles;

namespace Test.Content.Items.Weapons.Magic
{
    public class BloomingCrimtane : ModItem
    {
        public override void SetDefaults()
        {
            // Быстро выставляем дефолтные настройки для маг. оружия
            Item.DefaultToMagicWeapon(
                projType: ModContent.ProjectileType<Projectile1>(), // Стреляет нашим снарядом
                singleShotTime: 35, // useTime & useAnimation
                shotVelocity: 9f,
                hasAutoReuse: true
                );

            Item.damage = 45;
            Item.knockBack = 5f;
            Item.value = 10000;
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item94; // Звук
            Item.mana = 10; // Кол-во использ. маны
            Item.width = Item.height = 54;
        }

        public override Vector2? HoldoutOffset() => new Vector2(-8f, 0f); // Смещаем спрайт в руки персонажу

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<CoolStar>(15)
                .AddIngredient(ItemID.CrimtaneBar, 12)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}