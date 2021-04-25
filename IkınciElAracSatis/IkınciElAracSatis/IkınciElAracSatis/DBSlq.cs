using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkınciElAracSatis
{
    class DBSlq : Databases
    {
        public int sqlBaglantiSayisi { get; set; }
        public override void baglan()
        {
            Console.Write("Sql'e baglanildi.");
        }

        public override void sorgula()
        {
            Console.Write("Sql'de sorgulandi.");
        }
    }
}
