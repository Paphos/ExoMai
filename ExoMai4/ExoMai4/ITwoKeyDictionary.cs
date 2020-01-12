using System;

namespace ExoMai4
{
    public interface ITwoKeyDictionary<TKey1, TKey2, TValue>
    {
        int Count { get; }

        TValue this[TKey1 key1, TKey2 key2]
        { 
            get;
            set;
        }

        void Add(TKey1 key1, TKey2 key2, TValue value);
        void Remove(TKey1 key1, TKey2 key2);
        bool TryGetValue(TKey1 key1, TKey2 key2, out TValue value);
        bool ContainsKeys(TKey1 key1, TKey2 key2);
    }
}
