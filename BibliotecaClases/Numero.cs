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

        public Numero() //Constructor genérico
        {
            this.Numero1 = 0;
        }

        public Numero(string Numero) //Constructor que recibe como parametro un string
        {
            this.SetNumero(Numero);
        }

        public Numero(double Numero) //Constructor que recibe un booleano
        {
            this.Numero1 = Numero;
        }

        private double ValidarNumero(string Numero) //Método privado para validar el string Numero
        {  double Valido;

            if(double.TryParse(Numero, out Valido))
            {
                return Valido;
            }
            else {
                return 0;
            }
        }

        private void SetNumero(string Numero) //Método privado: Asigna un valor al atributo Numero1
        {
            
            this.Numero1=this.ValidarNumero(Numero);
        }

    }
}
