
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavsanPitlatici
{
    public class csDisiTavsan:csTavsan
    {
        public csDisiTavsan()
        {
            Yasi = 0;
            DogurmaSayisi = 0;
            HamileMi = false;
            DogurganMi = true;
            
        }
        public bool DogurganMi { get; set; }
        public bool HamileMi { get; set; }
        /// <summary>
        /// bu süre sonunda tavsan yavrularımız olacak
        /// </summary>
        public int HamilelikAyi { get; set; }
        
        /// <summary>
        /// Hamile ise doğum ayı geldiğinde yavru verecek sonuc. Bu yavruların dişilik ve erkeklikleri
        /// </summary>
        /// <returns></returns>
        public int? DogumYap()
        {
            if (!HamileMi)
            {
                //hani anne olsun.
                if (DogurganMi)
                {
                    HamileMi = true;
                    GebelikSuresi = 0; 
                    //0 diyince 
                    //normalde 0 dememiz lazım sonucta yeni ama döngü dönüceğik artıramayacazı derken böyle
                    
                    //1 diyince
                    //böyle olunca da motor gibi doğrdugu ay hamile kalıyor araya bir ay atsak mı aacaba sonucta emcekler falan
                }
            }
            else
            {
                if (GebelikSuresi == Ayarlar.DisiHamilelikSuresi)
                {
                    //dogurduk
                    GebelikSuresi = 0;
                    HamileMi = false;
                    DogurmaSayisi++;
                    return Ayarlar.DisiDogurabildigiYavruSayisi;
                }
                else
                {
                    GebelikSuresi++;
                }
            }
            
            return null;
        }
        public int GebelikSuresi { get; set; }
        public int DogurmaSayisi { get; set; }
        /// <summary>
        /// hamile değil ve doğurgan ise anne olacak
        /// </summary>
        public void HamileKal() { 
        
        }
    }
}
