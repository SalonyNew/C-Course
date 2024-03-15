using System;
using System.Collections.Generic;



namespace ArrayAssignment
{
     public class DataBase<TKey, TValue>
    {
        private TKey[] keys;
        private TValue[] values;
        private int count = 0;

        public DataBase()
        {
            keys = new TKey[4];
            values = new TValue[4];
            count = 0;
        }

        public void Add(TKey key, TValue value)
        {
            if (count == keys.Length)
            {
                System.Array.Resize(ref keys, keys.Length * 2);
                System.Array.Resize(ref values, values.Length * 2);
            }
            keys[count] = key;
            values[count] = value;
            count++;
        }
        
    public static void Main()
        {
            DataBase <int,string> db = new DataBase<int,string>();
            db.Add(1, "One");
            db.Add(2, "Two");
            db.Add(3, "Three");
            db.Add(4, "Four");
            Console.WriteLine(db.count);
            Console.WriteLine(db.keys);
        }
    }
}
