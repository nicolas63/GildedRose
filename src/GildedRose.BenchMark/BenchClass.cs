using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using GildedRose.Items;

namespace GildedRose.BenchMark
{
    public class BenchClass
    {
        public GildedRose GildedRose { get; set; }
        public GildedRoseGoldenMaster GildedRoseGoldenMaster { get; set; }
        
        public BenchClass()
        {
            var items = ItemRepository.GetAll();
            var items2 = ItemRepository.GetAll();

            GildedRose = new GildedRose(items);
            GildedRoseGoldenMaster = new GildedRoseGoldenMaster(items2);

        }

        [Benchmark]
        public void OldUpdateQuality()
        {
            GildedRoseGoldenMaster.UpdateQuality();
        }

        [Benchmark]
        public void NewUpdateQuality()
        {
            GildedRose.UpdateQuality();
        }

    }
}
