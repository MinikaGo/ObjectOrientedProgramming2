using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager tasitKredisiManager1 = new TasitKredisiManager();
            IKrediManager konutKredisiManager1 = new KonutKredisiManager();
            IKrediManager esnafKredisiManager1 = new EsnafKredisiManager();
            IKrediManager ihtiyacKredisiManager1 = new IhtiyacKredisiManager();

            Musteri musteri1 = new Musteri();
            musteri1.AdSoyad = "Mine Sinanoğlu";
            musteri1.HesapNo = "432156";

            Musteri musteri2 = new Musteri();
            musteri2.AdSoyad = "Ümit Sinanoğlu";
            musteri2.HesapNo = "1432156";

            GercekMusteri gercekMusteri1 = new GercekMusteri();
            gercekMusteri1.TcNo = "12345678901";

            TuzelMusteri tuzelMusteri1 = new TuzelMusteri();
            tuzelMusteri1.VergiNo = "1234567890";

            ILogger databaseLoggerService1 = new DatabaseLoggerService();
            ILogger smsLoggerService1 = new SMSLoggerService();
            ILogger fileLoggerService1 = new FileLoggerService();

            BasvuruManager basvuruYap1 = new BasvuruManager();
            basvuruYap1.BasvuruYap(tasitKredisiManager1, musteri1, databaseLoggerService1);
            basvuruYap1.BasvuruYap(esnafKredisiManager1, musteri2, smsLoggerService1);

            List<IKrediManager> topluOnBasvuruListe1 = new List<IKrediManager> {konutKredisiManager1, ihtiyacKredisiManager1 };
            List<IKrediManager> topluOnBasvuruListe2 = new List<IKrediManager> {esnafKredisiManager1, tasitKredisiManager1 };
            basvuruYap1.BireyselKrediBasvurusuYap(topluOnBasvuruListe1, gercekMusteri1, smsLoggerService1);
            basvuruYap1.KurumsalKrediBasvurusuYap(topluOnBasvuruListe2, tuzelMusteri1, smsLoggerService1);

        }
    }
}
