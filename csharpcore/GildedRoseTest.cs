using Xunit;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyModel;

namespace csharpcore
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
            GildedRose app = new GildedRose(Items);
            
            //First day
            app.UpdateQuality();
            Assert.Equal("+5 Dexterity Vest", Items[0].Name);
            Assert.Equal(9, Items[0].SellIn);
            Assert.Equal(19, Items[0].Quality);

            //Second day
            app.UpdateQuality();
            Assert.Equal("+5 Dexterity Vest", Items[0].Name);
            Assert.Equal(8, Items[0].SellIn);
            Assert.Equal(18, Items[0].Quality);

        }
    }
}