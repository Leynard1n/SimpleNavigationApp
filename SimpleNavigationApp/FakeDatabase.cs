using System.Collections.Generic;

namespace SimpleNavigationApp
{
    public static class FakeDatabase
    {
        private static List<Item> _items = new List<Item>
        {
            new Item { Name = "Item 1" },
            new Item { Name = "Item 2" },
            new Item { Name = "Item 3" }
        };

        public static List<Item> GetItems()
        {
            return _items;
        }
    }
}