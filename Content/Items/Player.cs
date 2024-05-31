using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Test
{
    public class GamePlayer : ModPlayer
    {
        public float damageBonus = 0.0f;
        public bool Absorber;

        public override void ResetEffects()
        {
            Absorber = false;
        }

        public override void OnHitByNPC(NPC npc, Player.HurtInfo hurtInfo)
        {
            if (Absorber)
            {
                damageBonus += 0.9f;
                /*if (damageBonus > 0.5f)
                {
                    damageBonus = 0.5f;
                }*/
                
                Main.NewText($"{damageBonus}");
            }
        }

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (Absorber)
            {
                //damageBonus -= 0.05f;
                //if (damageBonus <0.0f)
                //{
                //    damageBonus = 0.0f;
                //}
                Player.GetDamage(DamageClass.Generic) += damageBonus;
            }
        }
    }
}