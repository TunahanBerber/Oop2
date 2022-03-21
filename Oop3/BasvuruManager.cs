using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)//Burada avantaj şu hepsi interfaceye bağlanacak diğer kredi türlerine bağımlı kalmayacağız
        {
            //Başvuran Bilgilerini Değerlendirme
            krediManager.Hesapla();   //Hangi türü gönderirsen o kredi türünün referans numarası çalışır
            foreach (var loggerService  in loggerServices)
            {
                loggerService.Log();
            }  //Method injection  //Loglamanın çeşitleri vardır sms veritabanı dosya
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
