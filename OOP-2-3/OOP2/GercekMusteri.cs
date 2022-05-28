using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri:Musteri  //inheratance Musteri sınıfında olan özellikler GercekMusteri sınıfındada var kabul edilir.
    {
        
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
