using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BalaDeDoze : Balas
    {
        public string FabricarBalas()
        {
            return "Fabricando Balas de 12 BuckShot";
        }

        public string FabricarBalasAP()
        {
            return "Fabricando Balas de 12 BuckShot (AP)";
        }
    }
}
