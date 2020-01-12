using System.Collections.Generic;

namespace ExoMai4
{
    public interface IDictionaryOfList<TKey, TItem>
    {
        int ItemCount { get; }
        bool IsEmpty { get; }

        IEnumerable<TItem> this[TKey key]
        {
            get;
            set;
        }

        void Add(TKey key, TItem item);
        void AddRange(TKey key, IEnumerable<TItem> items);
        void Remove(TKey key, TItem item);
        void Remove(TKey key);
        IEnumerable<TItem> GetItemsFromKey(TKey key);
        IEnumerable<TItem> GetAllItems();
        bool ContainsKey(TKey key);
    }
}
