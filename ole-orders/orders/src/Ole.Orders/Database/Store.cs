using System.Collections.Generic;
using Serilog;

namespace Ole.Orders.Database
{
    public static class Store<T>
    {
        private static List<T> _items = new List<T>();

        public static List<T> Read() => _items;

        public static void Add(T item)
        {
            _items.Add(item);
            Log.Debug("Add OK!");
        }
    }
}
