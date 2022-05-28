using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) //Product türünde bir parametre ver
        {
            Console.WriteLine(product.ProductName + "Eklendi."); //ekleme işleminden sonra sonuç ile birşey yapmak istemiyorsam
            // void kullanırım.

        }

        public void Update(Product product)
        {
            Console.WriteLine((product.ProductName + "Güncellendi.");


        }

        
        
        
        
        
        
        
        
        
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;

        }
        // public void ve int farkı ===   void direk yapar ve bitirir return ü int ile kullanırsam fonksiyon içinde bulduğum
        //değeri int tipinde başka bir yerdede kullanabilirim fonksiyondan dönen sonucu kullanabilmeyilim istersem kendim yazdırırım.
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);

        }

    }
}
