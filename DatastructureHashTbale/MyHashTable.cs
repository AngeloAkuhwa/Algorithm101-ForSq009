using System;
using System.Collections.Generic;

namespace DatastructureHashTbale
{
   public class MyHashTable
   {
        internal class Entry
        {
            internal int Key;
            internal string Value;

            internal Entry(int key, string value)
            {
                this.Key = key;
                this.Value = value;
            }
        }

        private LinkedList<Entry>[] entries = new LinkedList<Entry>[5];

        public void Put(int key, string value)
        {
            var index = HasKey(key);

            if(entries[index] == null)
            {
                entries[index] = new LinkedList<Entry>();
            }

            var bucket = entries[index];

            foreach (var item in bucket)
            {
                if (item.Key == key)
                {
                    item.Value = value;

                    return;
                }
            }

            bucket.AddLast(new Entry(key, value));


        }

        public string Get(int key)
        {
            var index = HasKey(key);

            var bucket = entries[index];

            if(bucket != null)
            {
                foreach (var item in bucket)
                {
                    if (item.Key == key) return item.Value;
                }
            }

            return null;
        }

        public void Remove(int key)
        {
            var index = HasKey(key);

            var bucket = entries[index];

            if(bucket == null)
            {
                throw new ArgumentNullException("entry not forund");
            }

            foreach (var item in bucket)
            {
                if (item.Key == key)
                    bucket.Remove(item);
            }

            throw new ArgumentNullException("entry not forund");
        }
        private int HasKey(int key)
        {
            return Math.Abs(key) % entries.Length;
        }
    }
}
