using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkınciElAracSatis
{
    public abstract class Uyeler
    {
        public string isim { get; set; }

        public string soyisim { get; set; }

        public string eposta { get; set; }

        public string sifre { get; set; }

        public abstract bool HesapVarMı();
 
     
    }
}
