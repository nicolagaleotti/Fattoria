using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
    public class Squalo : Pesce
    {
        public Squalo() : base() { }
        public override string Nuota()
        {
            return "Lo Squalo nuota!";
        }
    }
}
