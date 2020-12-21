using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
    public class Cigno : Volatile, INuotatore
    {
        public Cigno() { }
        public override string Vola()
        {
            return "Il Cigno vola!";
        }

        public string Nuota()
        {
            return "Il Cingo nuota!";
        }
    }
}
