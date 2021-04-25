using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkınciElAracSatis
{
    class DBOracle : Databases
    {
        public int oracleBaglantiSayisi { get; set; }
        public override void baglan()
        {
            Console.Write("PL-SQL'e baglanildi.");
        }

        public override void sorgula()
        {
            Console.Write("PL-SQL'de sorgulandi.");
        }
    }
}
