using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
    public abstract class Pesce : Animale, INuotatore
    {
        public abstract string Nuota();
    }
}
