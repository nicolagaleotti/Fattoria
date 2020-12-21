using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
    public class Fattoria
    {
        public List<Animale> Animali { get; private set; }

        public Fattoria() { }
        public void Adotta (Animale a)
        {
            Animali.Add(a);
        }
    }
}
