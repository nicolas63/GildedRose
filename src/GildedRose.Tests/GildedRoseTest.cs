using System.Collections.Generic;
using FluentAssertions;
using GildedRose.Items;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests
{
    [TestClass]
    public class GildedRoseTest
    {
        [TestMethod]
        public void UpdateQualityTest()
        {
            var items1 = ItemRepository.GetAll();
            var items2 = ItemRepository.GetAll();

            var gildedRose = new GildedRose(items1);
            var gildedRoseGoldenMaster = new GildedRoseGoldenMaster(items2);


            for (var i = 0; i < 31; i++)
            {
                gildedRose.UpdateQuality();
                gildedRoseGoldenMaster.UpdateQuality();
            }

            items1.Should().BeEquivalentTo(items2);

        }
    }
}
