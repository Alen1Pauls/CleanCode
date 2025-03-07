using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamaraBasket
{
    public class DomainFactory
    {
        public List<Item> PrepareItemList(string name, int sellin, int quality)
        {
            return new List<Item>
            {
                new Item { Name = name, SellIn = sellin, Quality = quality },
            };
        }
        public void UpdateQualityHelper(List<Item> Items)
        {
            HamaraBasket app = new HamaraBasket(Items);
            app.UpdateQuality();
        }

    }

}
