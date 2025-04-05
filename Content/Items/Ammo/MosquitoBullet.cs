using TaleOfDragons.Content.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TaleOfDragons.Content.Items.Ammo
{
    internal class MosquitoBullet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 99;
        }

        public override void SetDefaults() 
        {
            Item.width = 26;
            Item.height = 9;
            Item.scale = .5f;
            Item.rare = ItemRarityID.Lime;
            Item.damage = 250;
            Item.DamageType = DamageClass.Ranged;
            Item.knockBack = 10f;
            Item.value = 10;
            Item.consumable = true;
            Item.shoot = ModContent.ProjectileType<MosquitoBulletProjectile>();
            Item.shootSpeed = 4.5f;
            Item.ammo = AmmoID.Bullet;
            Item.maxStack = Item.CommonMaxStack;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.LunarTabletFragment, 3)
                .AddIngredient(ItemID.ChlorophyteBar)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
