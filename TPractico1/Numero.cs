using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPractico1
{
    public class Numero
    {
        public double Numero1;

        public Numero()
        {
            this.Numero1 = 0;
        }

        public Numero(string Numero)
        {
            this.SetNumero(Numero);
        }

        public Numero(double Numero)
        {
            this.Numero1 = Numero;
        }

        private double ValidarNumero(string Numero)
        {  double Valido;

            if(double.TryParse(Numero, out Valido))
            {
                return Valido;
            }
            else {
                return 0;
            }
        }

        private void SetNumero(string Numero)
        {
            
            this.Numero1=this.ValidarNumero(Numero);
        }

    }
}
