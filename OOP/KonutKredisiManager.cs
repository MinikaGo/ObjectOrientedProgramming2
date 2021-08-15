﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class KonutKredisiManager : IKrediManager
    {
        public void Hesapla(Musteri musteri)
        {
            Console.WriteLine("{0} için Konut Kredisi Hesaplandı", musteri.AdSoyad);

        }
        public void BireyselKrediBasvuruYap(GercekMusteri gercekMusteri)
        {
            Console.WriteLine("{0} TC Kimlik no için Konut Kredisi Başvurusu Alındı", gercekMusteri.TcNo);

        }
        public void KurumsalKrediBasvuruYap(TuzelMusteri tuzelMusteri)
        {
            Console.WriteLine("{0} VKN için Kurumsal Konut Yatırım Kredisi Başvurusu Alındı", tuzelMusteri.VergiNo);

        }
    }
}