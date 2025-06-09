using Microsoft.Xna.Framework;
using TaleOfDragons.Content.Items.Ammo;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace TaleOfDragons.Content.Items.Weapons.Range
{
    internal class BigTom : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 50;
            Item.height = 50;
            Item.scale = 0.05f;
            Item.rare = ItemRarityID.Lime;
            Item.damage = 500;
            Item.DamageType = DamageClass.Ranged;
            Item.useTime = Item.useAnimation = 80;
            Item.knockBack = 10f;
            Item.autoReuse = true;
            Item.value = 102500;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.UseSound = SoundID.Item11;
            Item.shoot = ProjectileID.PurificationPowder;
            Item.shootSpeed = 10f;
            Item.noMelee = true;
            Item.useAmmo = AmmoID.Bullet;
        }

        public override Vector2? HoldoutOffset() => new Vector2(2f, -1f);
    }
}
