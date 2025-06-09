using Microsoft.Xna.Framework;
using TaleOfDragons.Content.Projectiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace TaleOfDragons.Content.Items.Weapons.Magic
{
    class DeathBreath : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.DefaultToMagicWeapon(ModContent.ProjectileType<DeathBreathProj>(), 50, 15f);
            Item.width = Item.height = 50;
            Item.rare = ItemRarityID.Lime;
            Item.damage = 80;
            Item.value = 300000;
            Item.knockBack = 2f;
            Item.UseSound = SoundID.Item43;
        }

        public override Vector2? HoldoutOffset() => new Vector2(1f, -1f);

        public override void AddRecipes()
        {
            CreateRecipe()
            .AddIngredient(ItemID.Bone, 50)
            .AddIngredient(ItemID.SoulofNight, 15)
            //.AddIngredient(ModContent.ItemType<>(), 3)
            .AddTile(TileID.Anvils);
        }
    }
}