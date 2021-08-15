using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class IhtiyacKredisiManager : IKrediManager
    {
        public void Hesapla(Musteri musteri)
        {
            Console.WriteLine("{0} için İhtiyaç Kredisi Hesaplandı", musteri.AdSoyad);

        }

        public void BireyselKrediBasvuruYap(GercekMusteri gercekMusteri)
        {
            Console.WriteLine("{0} TC Kimlik no için İhtiyaç Kredisi Ön Başvuru Alındı", gercekMusteri.TcNo);

        }
        public void KurumsalKrediBasvuruYap(TuzelMusteri tuzelMusteri)
        {
            Console.WriteLine("{0} VKN için İhtiyaç Kredisi Ön Başvuru Alındı", tuzelMusteri.VergiNo);

        }
    }
}