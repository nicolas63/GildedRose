using System.Collections.Generic;
using GildedRose.Items;

namespace GildedRose
{
    public static class ItemRepository
    {
        
        public static IList<AbstractItem> GetAll()
        {
            return new List<AbstractItem>{
                    new CommonItem() {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new AgedBrieItem() {Name = "Aged Brie", SellIn = 2, Quality = 0},
                    new CommonItem() {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new SulfurasItem() {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                    new SulfurasItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                    new BackStagePassesItem()
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20
                    },
                    new BackStagePassesItem
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 10,
                        Quality = 49
                    },
                    new BackStagePassesItem
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 5,
                        Quality = 49
                    },
                    new AgedBrieItem {Name = "Aged Brie", SellIn = -1, Quality = 6},
                    new CommonItem() {Name = "Elixir of the Mongoose", SellIn = -5, Quality = 7},
                    new BackStagePassesItem {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -3, Quality = 6},
                    // this conjured item does not work properly yet
                    new CommonItem() {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                };
        }
    }
}
