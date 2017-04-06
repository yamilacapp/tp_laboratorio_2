using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPractico1
{
    public class Calculadora
    {
        public Numero Obj1;
        public Numero Obj2;
        public string Operador;
        public double Resultado;



        public Calculadora(Numero Ob1, Numero Ob2, string Operacion)
        {
            this.Obj1 = Ob1;
            this.Obj2 = Ob2;
            this.Operador = Operacion;    //ValidarOperador(Operacion);
            this.Resultado = this.Operar(Ob1, Ob2, Operacion);
        }

        public double Operar(Numero Ob1, Numero Ob2, string Operacion)
        {
            switch (Operacion)
            {
                case "/":
                    if (Ob2.Numero1 != 0)
                    {

                        this.Resultado = Ob1.Numero1 / Ob2.Numero1;
                    }
                    else
                    {
                        this.Resultado = 0;
                    }
                    break;
                case "*": this.Resultado = Ob1.Numero1 * Ob2.Numero1;
                    break;
                case "+": this.Resultado = Ob1.Numero1 + Ob2.Numero1;
                    break;
                case "-": this.Resultado = Ob1.Numero1 - Ob2.Numero1;
                    break;

                default:
                    this.Resultado = Ob1.Numero1 + Ob2.Numero1;
                    break;

            }
            //Console.Write("{0}", this.Resultado);
            return this.Resultado;

        }

        public string ValidarOperador(string Operacion)
        {
            /* if(Operacion=="*"||Operacion=="/" ||Operacion=="+"||Operacion=="-")
             {
                 return Operacion;

             }
             else{

                 return "+";
             }
             */

            switch (Operacion)
            {
                case "/": return Operacion;


                case "*": return Operacion;

                case "+": return Operacion;
                   

                case "-": return Operacion;
                   

                default: return "+";
                   

            }
        }


    }
    
}
