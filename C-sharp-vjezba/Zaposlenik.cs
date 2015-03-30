using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_vjezba
{
    public abstract class Zaposlenik
    {
        public abstract string Ime { get; set; }
        public abstract string PrikaziIme();
    }
}
