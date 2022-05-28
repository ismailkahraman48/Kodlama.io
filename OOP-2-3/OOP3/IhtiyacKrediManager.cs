using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("ihtiyaç kredi ödeme planı oluştu"); 
            // kredi manager interface içinde tanımladığım methodu istediğim class içinde farklı farklı kullanabilirim.
        }
    }
}
