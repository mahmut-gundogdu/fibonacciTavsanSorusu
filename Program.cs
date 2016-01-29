using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavsanPitlatici
{
    class Program
    {
        static void Main(string[] args)
        {

            //AYARlarımızı Okuyup Cs Yazmalıyız.


            Console.WriteLine("TavsanMatik için Sonuç Görmek istediğiniz ayı giriniz örneğin 6. ay için 6 giriniz:");
            var SonucistenenAy = Convert.ToInt32(Console.ReadLine());

            //Kümesimiz
            List<csTavsan> ErkekTavsanlarimiz = new List<csTavsan>() { 
            new csTavsan(){ Yasi=1,EcelYasi=Ayarlar.ErkekOmru}
             };
            List<csDisiTavsan> DisiTavsanlarimiz = new List<csDisiTavsan>() { 
                new csDisiTavsan(){ Yasi=1,EcelYasi=Ayarlar.DisiOmru}
            };

            //baslangic daki 1 erkek 1 dişi tabasnımızı olusturup kümese kokuyoruz;


            // LETS COOK

            //burda ay ay işleyeceğiz.
            for (int t = 1; t <= SonucistenenAy; t++)
            {
                var yasayanErkekler = ErkekTavsanlarimiz.Where(u => u.YasiyorMu).ToList();
                foreach (var item in yasayanErkekler)
                {
                    item.Yaslandir();
                }

                var yasayanDisiler = DisiTavsanlarimiz.Where(u => u.YasiyorMu).ToList();
                int? yavruSayisi = null;
                foreach (var item in yasayanDisiler)
                {
                    item.Yaslandir();
                    yavruSayisi = item.DogumYap();
                    if (yavruSayisi != null)
                    {
                        var tmpx=Convert.ToDouble( yavruSayisi) * Ayarlar.DisiDogurduguErkekOrani / 100;

                        var x = Math.Round(tmpx);
                        int erkekYavru = Convert.ToInt16(x);

                        tmpx = Convert.ToDouble(yavruSayisi) * Ayarlar.DisiDogurduguDisiOrani / 100;
                        int disiYavru = Convert.ToInt16(Math.Round(tmpx));
                        for (int ey = 0; ey < erkekYavru; ey++)
                        {
                            var tmp = new csTavsan() { Yasi = 0, EcelYasi = Ayarlar.ErkekOmru };
                            ErkekTavsanlarimiz.Add(tmp);
                        }
                        for (int ey = 0; ey < erkekYavru; ey++)
                        {
                            var tmp = new csDisiTavsan() { Yasi = 0, EcelYasi = Ayarlar.DisiOmru };
                            DisiTavsanlarimiz.Add(tmp);
                        }
                    }

                }
                var ErkekSayisi = ErkekTavsanlarimiz.Count(u => u.YasiyorMu);
                var DisiSayisi = DisiTavsanlarimiz.Count(u => u.YasiyorMu);

                //Console.WriteLine("{0} zamanında {1} Disi {2} Erkek Mevcut. Yeni Yavru:{3}", t, DisiSayisi, ErkekSayisi, yavruSayisi);
                Console.WriteLine("{0} zamanında {1} Disi {2} Erkek Mevcut.", t, DisiSayisi, ErkekSayisi);
            }


            //List<csTavsan> mg = new List<csTavsan>()
            //{
            //    new csDisiTavsan() {Yasi=1, EcelYasi=Ayarlar.DisiOmru},
            //    new csTavsan() {Yasi=1, EcelYasi=Ayarlar.ErkekOmru}
            //};
            //for (int i = 0; i < mg.Count; i++)
            //{

            //    var item = mg[i];

            //    if (item is csDisiTavsan)
            //    {
            //        Console.WriteLine("dişi");
            //    }
            //    else
            //    {
            //        Console.WriteLine("erkek");
            //    }
            //}
            //kapanma kısmı
            Console.WriteLine("İşlem Tamamlandı. Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}
