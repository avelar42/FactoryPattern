using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class BalaRifle : Balas
    {
        public string FabricarBalas()
        {
            return "Fabricando Balas de rifle 5.56";
        }

        public string FabricarBalasAP()
        {
            return "Fabricando Balas de rifle 5.56 (AP)";
        }
    }
}
