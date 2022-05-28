using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasıtKrediManager : IKrediManager //kredi manager içinde kullanılan fonksiyona sahip
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("taşıt kredi ödeme planı oluştu");
        }
    }
}
