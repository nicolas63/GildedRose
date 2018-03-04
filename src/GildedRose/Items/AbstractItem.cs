namespace GildedRose.Items
{
    public abstract class AbstractItem
    {
        private const int MinQuality = 0;
        private const int MaxQuality = 50;

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        private void DecreaseQuality()
        {
            Quality = Quality - 1;
        }

        private void IncreaseQuality()
        {
            Quality = Quality + 1;
        }

        protected void DecreaseSellIn()
        {
            SellIn = SellIn - 1;
        }

        protected bool IsExpired()
        {
            return SellIn < MinQuality;
        }

        protected void DecreaseQualityIfPossible()
        {
            if (Quality > AbstractItem.MinQuality)
                DecreaseQuality();
        }

        protected void IncreaseQualityIfPossible()
        {
            if (this.Quality < MaxQuality)
            {
                this.IncreaseQuality();
            }
        }

        public abstract void UpdateQuality();

    }
}
