using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BalaRevolver : Balas
    {
        public string FabricarBalas()
        {
            return "Fabricando Balas de revolver 9mm";
        }

        public string FabricarBalasAP()
        {
            return "Fabricando Balas de revolver 9mm (AP)";
        }
    }
}
