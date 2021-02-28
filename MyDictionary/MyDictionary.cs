using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<TKey,TValue>
    {
        TKey[] tKey;
        TValue[] tValue;

        TKey[] tKeyTemp;
        TValue[] tValueTemp;

        public MyDictionary()
        {
            tKey = new TKey[0];
            tValue = new TValue[0];

        }

        public void Add(TKey key, TValue value)
        {
            tKeyTemp = tKey;
            tValueTemp = tValue;

            tKey = new TKey[tKey.Length + 1];
            tValue = new TValue[tValue.Length + 1];

            for (int i = 0; i < tKeyTemp.Length; i++)
            {
                tKey[i] = tKeyTemp[i];
                tValue[i] = tValueTemp[i];
            }
            tKey[tKey.Length - 1] = key;
            tValue[tValue.Length - 1] = value;
            tKeyTemp = new TKey[0];
            tValueTemp = new TValue[0];

        }

        public int Count { get=> tKey.Length;  }
    }
}
