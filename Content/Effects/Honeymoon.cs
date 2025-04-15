using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TaleOfDragons.Content.Effects
{
    internal class Honeymoon : ModBuff
    {
        public static readonly int defenseBonus = 5;
        public static readonly int damageBonus = 15;
        public static readonly int healthReduction = 30;

        public override LocalizedText Description => base.Description.WithFormatArgs(damageBonus, defenseBonus, healthReduction);

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += defenseBonus;
            player.GetDamage<GenericDamageClass>() += damageBonus;
            player.statLifeMax2 -= healthReduction;
        }
    }
}
