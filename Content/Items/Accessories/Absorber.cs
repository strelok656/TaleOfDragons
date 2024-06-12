using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;


namespace Test.Content.Items.Accessories 
{
    
    public class Absorber: ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 30;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.endurance = 0.9f;
            /*player.GetModPlayer<GamePlayer>().Absorber = true;*/
        }
    }
}