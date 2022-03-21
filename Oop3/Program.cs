using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();   //İnterfaceler de o interfaceyi implemente eden classın referans numarasını tutabilir

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();  //BURDA YAPILAN enjection yazılımda sürdürülebilirliği sağlar
            ILoggerService smLoggerService = new SmsLoggerService();
            
            List<ILoggerService>loggers = new List<ILoggerService>{fileLoggerService,databaseLoggerService,smLoggerService};



            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), loggers);  //İNTERFACE BEREMESSİN O NEWLENEMEZ, hangi kredi türünü seçersen onun fonksiyonu çalışır

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
        
    }
}
