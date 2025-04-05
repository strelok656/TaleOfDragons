using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TaleOfDragons.Content.Projectiles
{
    internal class MosquitoBulletProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 26;
            Projectile.height = 9;
            Projectile.scale = 1f;
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.timeLeft = 300;
            Projectile.damage = 100;
        }
        
        public override void OnKill(int timeLeft)
        {
            
            Vector2 launchVelocity = new(Main.rand.Next(-10, 10), Main.rand.Next(-10, 10));
            if (Main.myPlayer == Projectile.owner)
            {
                for (int i = 0; i < 3; i++)
                    Projectile.NewProjectile(Projectile.InheritSource(Projectile), Projectile.Center, launchVelocity, ModContent.ProjectileType<Mosquito>(), Projectile.damage / 2, Projectile.knockBack, Projectile.owner);
            }   
        }

        public override void AI()
        {
            Projectile.rotation = (float)Math.Atan2((double)Projectile.velocity.Y, (double)Projectile.velocity.X);
        }
    }
}