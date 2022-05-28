using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "ismail", "engin", "kerem", "halil" }; ctrl k ve ctrl c ile yorum satılı yapılır

            List<string> isimler2 = new List<string> { "ismail", "engin", "kerem", "halil" };  //list i tanımlamak için soldaki ampule tıkla ve using system yap
            
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);

            



        }
           
    }
}
