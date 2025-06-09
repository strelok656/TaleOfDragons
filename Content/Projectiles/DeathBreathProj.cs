using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TaleOfDragons.Content.Projectiles
{
    internal class DeathBreathProj : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = Projectile.height = 20;
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.timeLeft = 500;
            Projectile.DamageType = DamageClass.Magic;
            Projectile.damage = 100;
        }

        public override void OnKill(int timeLeft)
        {
            Vector2 launchVelocity = new Vector2(0, 0);
            if (Main.myPlayer == Projectile.owner)
            {
                for (int i = 0; i < 3; i++)
                    Projectile.NewProjectile(Projectile.InheritSource(Projectile), Projectile.Center, launchVelocity, ModContent.ProjectileType<DeathBreathCloud>(), Projectile.damage / 2, Projectile.knockBack, Projectile.owner);
            }
        }

        public override void AI()
        {
            if(Main.netMode != NetmodeID.Server)
            {
                Dust dust = Dust.NewDustPerfect(Projectile.Center, DustID.WitherLightning, Vector2.Zero, 100, Color.White, 0.8f);
                dust.noGravity = true;
                dust.fadeIn = -1f;
            }
            Projectile.rotation = (float)Math.Atan2((double)Projectile.velocity.Y, (double)Projectile.velocity.X);
        }
    }
}
