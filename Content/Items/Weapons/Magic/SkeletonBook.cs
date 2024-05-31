using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Test.Content.Items.Materials;
using Test.Content.Projectiles;

namespace Test.Content.Items.Weapons.Magic
{
    public class SkeletonBook : ModItem
    {
        public override void SetDefaults()
        {
            // ������� ������ ��������� ��������� ��������� ����������� ������
            Item.DefaultToMagicWeapon(
                projType: ModContent.ProjectileType<Projectile1>(), //��� ������
                singleShotTime: 35, // useTime & useAnimation
                shotVelocity: 9f,
                hasAutoReuse: true
                );

            Item.damage = 45;
            Item.knockBack = 5f;
            Item.value = 10000;
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item94; //������������� ����
            Item.mana = 10; //������� ���������� 10 ����
            Item.width = Item.height = 40;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<CoolStar>(15)
                .AddIngredient(ItemID.Bone, 30)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}