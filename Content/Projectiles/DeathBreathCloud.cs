using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TaleOfDragons.Content.Projectiles
{
    internal class DeathBreathCloud : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 50;
            Projectile.height = 20;
            Projectile.friendly = true;
            Projectile.damage = 20;
            Projectile.timeLeft = 300;
            Projectile.penetrate = -1;
            Projectile.DamageType = DamageClass.Magic;
        }

        public override void ModifyHitNPC(NPC target, ref NPC.HitModifiers modifiers)
        {
            target.AddBuff(BuffID.Venom, 50);
        }

        public float Timer { get => Projectile.ai[0]; set => Projectile.ai[0] = value; }

        public override void AI()
        {
            if(Main.netMode != NetmodeID.Server)
            {
                Timer++;
                if(Timer == 29)
                {
                    Dust.NewDust(Projectile.Center, 3, 2, DustID.WitherLightning, 0, 2, 30);
                    Timer = 0;
                }
            }
        }
    }
}
