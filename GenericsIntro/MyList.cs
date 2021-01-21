using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor

        public MyList() //new lediğimiz anda otomatik çalışır. Array oluştu ve 0 eleman olarak tanımladık.
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //new lediğimiz anda referans numarası kaybolduğu için geçiçi diziye (tempArray'e) tutturuyoruz. tempArray'in yeni referansı items'ın referansı.
            
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++) //tempArray'in bütün elemanlarını items'a geri atıyoruz
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; // neden -1 6 elemanlıysa 5. index'i vermek için sıfırdan başladığı için
        }
    }
}
