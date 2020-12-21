using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fattoria;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Fattoria.Fattoria f = new Fattoria.Fattoria();
            Pesce s = new Squalo();
            Console.WriteLine(s.Nuota());
            f.Adotta(s);
        }
    }
}
