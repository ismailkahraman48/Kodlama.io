using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {       //metodun hangi kredi türü olacağını ve log lama türünü enjekte ediyorum. (method injection)
        public void BasvuruYap(IKrediManager kredimanager,ILoggerService loggerService) //hespinin referansını tutan interface i kredi manager olarak burda tanımlarım
        {// istersem konut ihtiyaç taşıt için ayrı ayrı başvuru açabilirim.


            kredimanager.Hesapla();
            loggerService.Log(); // hangi servis seçilmişse onu loglar




        //    KonutKrediManager konutKrediManager = new KonutKrediManager();
        //    konutKrediManager.Hesapla(); //böyle yaparsam tüm başvurular konut kredisi üzerinden hesaplanır
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {//birden fazla kredinin hesabını yapmak için liste içinde IkrediManager interface ile tutarım.
            foreach (var kredi in krediler)
            {// listedeki herbir kredinin hesabını for döngüsü ile yaptırdık
                kredi.Hesapla();

            }
        }


    }
}
