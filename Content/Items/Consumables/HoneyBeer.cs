using TaleOfDragons.Content.Effects;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TaleOfDragons.Content.Items.Consumables
{
    class HoneyBeer : ModItem
    {
        public static readonly int defenseBonus = 5;
        public static readonly int damageBonus = 15;
        public static readonly int healthReduction = 30;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(damageBonus, defenseBonus, healthReduction);

        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 10;
        }

        public override void SetDefaults()
        {
            Item.height = Item.width = 15;
            Item.scale = 0.8f;
            Item.value = 100;
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.UseSound = SoundID.Item3;
            Item.useTime = Item.useAnimation = 15;
            Item.useTurn = true;
            Item.maxStack = Item.CommonMaxStack;
            Item.buffType = ModContent.BuffType<Honeymoon>();
            Item.buffTime = 18300;
        }
    }
}
