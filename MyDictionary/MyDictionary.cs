using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T>
    {
        T[] items;
        //constructor
        public MyDictionary()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;  //önce ki diziyi hafızaya kaydettik.
            items = new T[items.Length + 1];  //1 değer fazlalı dizi oluşturduk.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];  //hafızada ki verileri, yeni diziye aktardık.
            }

            items[items.Length - 1] = item;  //0 dan başladığı için, son değere gelen item değerimizi ekledik.
        }


        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
