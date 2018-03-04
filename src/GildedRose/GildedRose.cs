using System;
using System.Collections.Generic;
using GildedRose.Items;

namespace GildedRose
{
    public class GildedRose
    {
        IList<AbstractItem> Items;
        public GildedRose(IList<AbstractItem> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.UpdateQuality();
            }
        }
    }
}

