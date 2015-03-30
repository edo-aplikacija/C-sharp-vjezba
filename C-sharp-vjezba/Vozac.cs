using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_vjezba
{
    public class Vozac: IZaposlenik
    {
        protected string ime;
        public string Ime
        {
            get
            {
                return this.ime;
            }
            set
            {
                this.ime = value;
            }
        }

        public string PrikaziIme()
        {
            return this.ime;
        }
    }
}
