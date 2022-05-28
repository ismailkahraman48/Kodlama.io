using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager // ampule basıp ıntrement interface diyosun bağlıyosun
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("konut kredi ödeme planı oluştu");
        }
    }
}
