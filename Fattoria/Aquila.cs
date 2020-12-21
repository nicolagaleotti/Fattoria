using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
    public class Aquila : Volatile
    {
        public Aquila() { }
        public override string Vola()
        {
            return "L'Aquila vola!";
        }
    }
}
