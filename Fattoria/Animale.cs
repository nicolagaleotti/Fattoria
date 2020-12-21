using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria
{
    public abstract class Animale : ISalutatore
    {
        public string Nome { get; set; }

        string ISalutatore.Saluta()
        {
            throw new NotImplementedException();
        }
    }
}
