using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkınciElAracSatis
{
    class UyeMusteri : Uyeler, IYorumYap, IKarsilastir, IVitrinIlanlariIslemleri
    {
        public int musteriNo { get; set; }

        public override bool HesapVarMı()
        {
            if (true)
            {
                return true;
            }
        }

        public string yorumlariGetir()
        {
            return "Bu araba cok iyi.";
        }
        public string IlanKarsilastir()
        {
            return "Iki arac karsilastiriliyor.";
        }

        public string vitrinAra()
        {
            return "Musteri vitrinde ilan aranıyor.";
        }

        public string vitrinGoruntule()
        {
            return "Musteri vitrindeki ilan görüntüleniyor.";
        }

        public string vitrinOlustur()
        {
            return "Musteri vitrin olusturdu.";
        }
    }
}
