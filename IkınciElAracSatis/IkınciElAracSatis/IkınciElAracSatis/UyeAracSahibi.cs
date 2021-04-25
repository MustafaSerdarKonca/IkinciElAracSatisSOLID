using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkınciElAracSatis
{
    class UyeAracSahibi : Uyeler, IVitrinIlanlariIslemleri, IIlanIslemleri
    {
        public int aracSahibiNo { get; set; }

        public override bool HesapVarMı()
        {
            if (true)
            {
                return true;
            }
        }

        public string vitrinAra()
        {
            return "Arac sahibi vitrinde ilan aranıyor.";
        }

        public string vitrinGoruntule()
        {
            return "Arac sahibi vitrindeki ilan görüntüleniyor.";
        }

        public string vitrinOlustur()
        {
            return "Arac sahibi vitrin olusturdu.";
        }
        public string ilanEkle()
        {
            return "Arac Sahibi Ilani Ekledi.";
        }

        public string ilanGuncelle()
        {
            return "Arac Sahibi Ilani Guncelledi.";
        }

        public string ilanSil()
        {
            return "Arac Sahibi Silindi.";
        }

    }
}
