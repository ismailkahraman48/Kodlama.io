using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //!!!IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); //***********!!!!!!!!!!!!!**************
            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); // bu şekilde Ihtiyackredi manageri kalıtımı olan base IkrediManager ilede çağırabilirim
            // !!!Hepsi için geçerli interfaceler ile tüm kalıtımlı class ları tutabilirim.
            //ihtiyacKrediManager.Hesapla();

            //TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();
            //tasıtKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            
            ILoggerService databaseLoggerService = new DatabaseLoggerService(); // bu şekilde yada parantez içinde new ile açılabilir
            ILoggerService fileLoggerService = new FileLoggerService();         // logger larımı da main nim içinde tanımlayıp kullancağım
            // alternatif == basvuruManager.BasvuruYap(konutKrediManager new databaseLoggerService());
           
            basvuruManager.BasvuruYap(konutKrediManager,databaseLoggerService); // database ya da file a loglayabilirim

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            // basvurumanager classı için tanımladığım for döngüsü ile liste içine atadığım kredi türlerini hesapladım.

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
