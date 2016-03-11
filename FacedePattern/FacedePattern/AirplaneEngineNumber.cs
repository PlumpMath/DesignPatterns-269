using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacedePattern
{
    public class AirplaneEngineNumber
    {
        public int engineNro { get; set; }

        public void setNumber(int nro) {
            if (nro < 5 && (nro % 2 == 0))
            {
                engineNro = nro;
            }
            else {
                engineNro = 4;
            }
        }
    }
}
