using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictinoryDemo
{
    class MyDictinory<K, V>
    {
        K[] keys;
        V[] values;
        public MyDictinory()

        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {

            K[] tempKey = keys; //geçici liste
            V[] tempValue = values; //geçici liste

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }

            keys[keys.Length-1] = key;
            values[values.Length-1] = value;
            
        }

        public void GetAll()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + "==>" + values[i]);
            }
        }
    }
}
