using System;
using System.Collections.Generic;

namespace CodeblogHashtable
{
    class HashTable<TKey, TValue>
    {
        private List<TValue>[] items;

        public HashTable(int size)
        {
            items = new List<TValue>[size];
        }

        public void Add(TKey key, TValue value)
        {
            var k = GetHash(key);
            if (items[k] == null)
            {
                items[k] = new List<TValue>() { value };
            }
            else
            {
                items[k].Add(value);
            }
        }

        public bool Search(TKey key, TValue item)
        {
            var k = GetHash(key);
            return items[k]?.Contains(item) ?? false;
        }

        private int GetHash(TKey key)
        {
            return Convert.ToInt32(key.ToString().Substring(0, 1));
        }
    }
}
