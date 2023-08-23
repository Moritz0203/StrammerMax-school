using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrammerMax
{
    class Gericht
    {
        public Fleisch Fleischsorte;
        public Soße Soßensorte;
        public Brot Brotsorte;

        public Gericht()
        {
            Fleischsorte = Fleisch.Pute;
            Soßensorte = Soße.Aioli;
            Brotsorte = Brot.Brötchen;
        }
    }

}
