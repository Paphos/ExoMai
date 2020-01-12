using System.Collections.Generic;
using System.Linq;

namespace ExoMai4
{
    public class TwoKeyDictionary<TKey1, TKey2, TValue> : ITwoKeyDictionary<TKey1, TKey2, TValue>
    {
        private Dictionary<TKey1, Dictionary<TKey2, TValue>> _values = new Dictionary<TKey1, Dictionary<TKey2, TValue>>();

        public int Count
        {
            get => _values.Values.Select(dico => dico.Count).Sum();
        }

        public TValue this[TKey1 key1, TKey2 key2]
        {
            get => _values[key1][key2];
            set => Add(key1, key2, value);
        }

        public void Add(TKey1 key1, TKey2 key2, TValue value)
        {
            Dictionary<TKey2, TValue> innerDico;
            if (!_values.TryGetValue(key1, out innerDico))
            {
                innerDico = _values[key1] = new Dictionary<TKey2, TValue>();
            }
            innerDico[key2] = value;
        }

        public void Remove(TKey1 key1, TKey2 key2)
        {
            Dictionary<TKey2, TValue> innerDico;
            if (_values.TryGetValue(key1, out innerDico))
            {
                innerDico.Remove(key2);
                if (innerDico.Count == 0)
                {
                    _values.Remove(key1);
                }
            }
        }

        public bool TryGetValue(TKey1 key1, TKey2 key2, out TValue value)
        {
            Dictionary<TKey2, TValue> innerDico;
            if (_values.TryGetValue(key1, out innerDico))
            {
                return innerDico.TryGetValue(key2, out value);
            }

            value = default(TValue);
            return false;
        }

        public bool ContainsKeys(TKey1 key1, TKey2 key2)
        {
            Dictionary<TKey2, TValue> innerDico;

            return _values.TryGetValue(key1, out innerDico)
                && innerDico.ContainsKey(key2);
        }
    }
}
