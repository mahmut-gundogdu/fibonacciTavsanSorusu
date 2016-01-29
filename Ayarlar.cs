using Gini;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavsanPitlatici
{
    public class Ayarlar
    {
        static Ayarlar()
        {
            var ayarmetni= System.IO.File.ReadAllText("AYARLAR.ini");
            var config = Ini.ParseHash(ayarmetni);
            var tavsanTag = config["Tavsan"];

            //ayardan string olarak okuyup convert edeceğiz
            var _ErkekOmru = tavsanTag["ErkekOmru"];
            var _DisiOmru = tavsanTag["DisiOmru"];
            var _DisiHamilelikSuresi = tavsanTag["DisiHamilelikSuresi"];
            var _DisiDogurganlikYitirmeSuresi = tavsanTag["DisiDogurganlikYitirmeSuresi"];
            var _DisiDogurabildigiYavruSayisi = tavsanTag["DisiDogurabildigiYavruSayisi"];
            var _DisiDogurduguDisiOrani = tavsanTag["DisiDogurduguDisiOrani"];
            var _DisiDogurduguErkekOrani = tavsanTag["DisiDogurduguErkekOrani"];

            //google a göre tavsanlar 5-12 yıl yaşarmış
            ErkekOmru = Convert.ToInt16( _ErkekOmru);
            DisiOmru = Convert.ToInt16(_DisiOmru); ;
            DisiHamilelikSuresi = Convert.ToInt16(_DisiHamilelikSuresi); ;
            DisiDogurganlikYitirmeSuresi = Convert.ToInt16(_DisiDogurganlikYitirmeSuresi); ;
            DisiDogurabildigiYavruSayisi = Convert.ToInt16(_DisiDogurabildigiYavruSayisi); ;
            DisiDogurduguDisiOrani = Convert.ToInt16(_DisiDogurduguDisiOrani); ;
            DisiDogurduguErkekOrani = Convert.ToInt16(_DisiDogurduguErkekOrani); ;
        }


        public static int ErkekOmru { get; set; }
        public static int DisiOmru { get; set; }
        /// <summary>
        /// Bir seferde doğurdugu tavsan adedi.
        /// </summary>
        public static int DisiDogurabildigiYavruSayisi { get; set; }

        /// <summary>
        /// Değer 20 30 55 şeklindedir bu %20 %30 demektir.
        /// </summary>
        public static int DisiDogurduguErkekOrani { get; set; }
        public static int DisiDogurduguDisiOrani { get; set; }
        /// <summary>
        /// Ay olarak Hamilelik Süresi
        /// </summary>
        public static int DisiHamilelikSuresi { get; set; }
        public static int DisiDogurganlikYitirmeSuresi { get; set; }
    }
}
