using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // MyList im de T bana bir tip ver ona göre liste oluşturayım dedim.
    {
        T[] items; //string yerine T ile tanımladım daha sonra string olduğunu anlayacak.

        //Constructer
        public MyList() //ctor tab tab
        {
            items = new T[0]; // burda arrayi oluşturup 0 eleman verdim T[0] 0 elemandan oluşturduğum listeyi array kullanabilmem için
            // new lemem lazım!!
        }




        public void Add(T item) // T yerine string int yazsam listede onlarla çalışırdım T yazmamın sebebi ben ne tür bir tip verirsem ona göre çalışır
        {
            T[] tempArray = items; //geçici dizinin referansı items ın referansı böylelikle yeni liste oluştuğunda elemanlar kaybolmaz
            items = new T[items.Length+1]; //listemin eleman sayısını 1 artırıyorum

            for (int i = 0; i < tempArray; i++) // for + tab x2 - 0 dan başlayıp temparray uzunluğu kadar gez
            {
                items[i] = tempArray[i]; //böylelikle itemsa her yeni new de hafızadan silinen  liste değerleri geri geldi
            }

            items[items.Length - 1] = item;

        }



    }
}
