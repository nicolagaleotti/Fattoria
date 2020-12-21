using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
    public class PesceVolante : Pesce, IVolante
    {
        public PesceVolante() { }
        public override string Nuota()
        {
            return "Il PesceVolante nuota!";
        }

        public string Vola()
        {
            return "Il PesceVolante vola!";
        }
    }
}
