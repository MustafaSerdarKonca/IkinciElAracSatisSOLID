using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkınciElAracSatis
{
    internal class UyeAdmin : Uyeler, IlanOnayla, IIlanIslemleri
    {
        public int adminNo { get; set; }

        public override bool HesapVarMı()
        {
            if (true)
            {
                return true;
            }
        }
        public string IlanOnayla()
        {
            return "Ilan onaylandı.";
        }

        public string ilanEkle()
        {
            return "Admin Ilani Ekledi.";
        }

        public string ilanGuncelle()
        {
            return "Admin Ilani Guncelledi.";
        }

        public string ilanSil()
        {
            return "Admin Ilani Silindi."; 
        }

    }
}
