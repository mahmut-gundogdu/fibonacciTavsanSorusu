using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavsanPitlatici
{
    public class csTavsan
    {
        private int tavsanYasi;

        public int Yasi
        {
            get { return tavsanYasi; }
            set
            {
                tavsanYasi = value;
                //burda ölü diri işlemleri
                //dişiler için Doğurganlık var mı? ona göre pıtlat fonksiyonu çalışacak
            }
        }
        public void Yaslandir()
        {
            Yasi++;
        }


        /// <summary>
        /// Ayarlardaki yaşama süresine geldi veya geçti ise ölür
        /// </summary>
        public bool YasiyorMu
        {
            get { return !OluMu(); }

        }
        public int EcelYasi { get; set; }
        public bool OluMu()
        {
            return EcelYasi <= Yasi;
        }

    }
}
