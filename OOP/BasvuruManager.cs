using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, Musteri musteri, ILogger logger)
        {
            krediManager.Hesapla(musteri);
            logger.Log();
        }

        public void BireyselKrediBasvurusuYap(List<IKrediManager> basvurular, GercekMusteri gercekMusteri, ILogger logger)
        {
            foreach (var basvuru in basvurular)
            {
                basvuru.BireyselKrediBasvuruYap(gercekMusteri);
                logger.Log();
            }
        }
        public void KurumsalKrediBasvurusuYap(List<IKrediManager> basvurular, TuzelMusteri tuzelMusteri, ILogger logger)
        {
            foreach (var basvuru in basvurular)
            {
                basvuru.KurumsalKrediBasvuruYap(tuzelMusteri);
                logger.Log();
            }
        }
    }
}
