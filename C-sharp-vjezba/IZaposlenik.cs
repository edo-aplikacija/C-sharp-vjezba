using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_vjezba
{
    public interface IZaposlenik
    {
        string Ime { get; set; }
        string PrikaziIme();
    }
}
