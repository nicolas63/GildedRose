namespace GildedRose.Items
{
    public class BackStagePassesItem : AbstractItem
    {
        public override void UpdateQuality()
        {
            IncreaseQualityIfPossible();
            if (SellIn < 11)
            {
                IncreaseQualityIfPossible();
            }

            if (SellIn < 6)
            {
                IncreaseQualityIfPossible();
            }

            DecreaseSellIn();

            if (IsExpired())
            {
                Quality = 0;
            }
        }
    }
}
