namespace GildedRose.Items
{
    public class AgedBrieItem : AbstractItem
    {
        public override void UpdateQuality()
        {
            IncreaseQualityIfPossible();
            DecreaseSellIn();
            if (IsExpired())
            {
                IncreaseQualityIfPossible();
            }
        }
    }
}
