namespace GildedRose.Items
{
    public class CommonItem : AbstractItem
    {
        public override void UpdateQuality()
        {
            DecreaseQualityIfPossible();
            DecreaseSellIn();

            if (IsExpired())
            {
                DecreaseQualityIfPossible();
            }
        }
    }
}
