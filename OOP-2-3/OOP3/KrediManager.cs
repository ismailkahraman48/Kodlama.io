using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager // interface kullanmamızın sebebi diğer kredi hesaplama sınıflarında base olarak aldığımız kredi manager içindeki
        // fonksiyonu kullanabilsin istiyorum. I harfiyle başlatırız interface olduğunu anlamak için.
    {
        void Hesapla();
        void BiseyYap();
        
        // interface i birbirinin alternatifi olan ama kod içerikleri farklı olan sınıflar için tutarız.

    }
    
        
        
            
        
    
}
