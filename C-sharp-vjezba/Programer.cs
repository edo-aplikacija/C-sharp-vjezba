using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_vjezba
{
    public class Programer: Zaposlenik
    {
        protected string ime;

        public override string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                this.ime = value;
            }
        }

        public override string PrikaziIme()
        {
            return this.ime;
        }
    }
}
