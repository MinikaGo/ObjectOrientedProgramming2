using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class EsnafKredisiManager : IKrediManager
    {
        public void Hesapla(Musteri musteri)
        {
            Console.WriteLine("{0} için Esnaf Kredisi Hesaplandı", musteri.AdSoyad);

        }

        public void BireyselKrediBasvuruYap(GercekMusteri gercekMusteri)
        {
            Console.WriteLine("{0} TC Kimlik no için Esnaf Kredisi Ön Başvuru Alındı", gercekMusteri.TcNo);

        }
        public void KurumsalKrediBasvuruYap(TuzelMusteri tuzelMusteri)
        {
            Console.WriteLine("{0} VKN için Esnaf Kredisi Ön Başvuru Alındı", tuzelMusteri.VergiNo);

        }
    }
}
