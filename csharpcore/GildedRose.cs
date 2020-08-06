using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var item = 0; item < Items.Count; item++)
            {
                UpdateItem(item);
            }
        }

        public void UpdateItem(int item)
        {
            if (Items[item].Name != "Aged Brie" && Items[item].Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (Items[item].Quality > 0)
                {
                    if (Items[item].Name != "Sulfuras, Hand of Ragnaros")
                    {
                        Items[item].Quality = Items[item].Quality - 1;
                    }
                }
            }
            else
            {
                if (Items[item].Quality < 50)
                {
                    Items[item].Quality = Items[item].Quality + 1;

                    if (Items[item].Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (Items[item].SellIn < 11)
                        {
                            if (Items[item].Quality < 50)
                            {
                                Items[item].Quality = Items[item].Quality + 1;
                            }
                        }

                        if (Items[item].SellIn < 6)
                        {
                            if (Items[item].Quality < 50)
                            {
                                Items[item].Quality = Items[item].Quality + 1;
                            }
                        }
                    }
                }
            }

            if (Items[item].Name != "Sulfuras, Hand of Ragnaros")
            {
                Items[item].SellIn = Items[item].SellIn - 1;
            }

            if (Items[item].SellIn < 0)
            {
                if (Items[item].Name != "Aged Brie")
                {
                    if (Items[item].Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (Items[item].Quality > 0)
                        {
                            if (Items[item].Name != "Sulfuras, Hand of Ragnaros")
                            {
                                Items[item].Quality = Items[item].Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        Items[item].Quality = Items[item].Quality - Items[item].Quality;
                    }
                }
                else
                {
                    if (Items[item].Quality < 50)
                    {
                        Items[item].Quality = Items[item].Quality + 1;
                    }
                }
            }
        }
    }
}
