using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    interface IKrediManager
    {
        void Hesapla(Musteri musteri);
        void BireyselKrediBasvuruYap(GercekMusteri gercekMusteri);
        void KurumsalKrediBasvuruYap(TuzelMusteri tuzelMusteri);


    }
}
