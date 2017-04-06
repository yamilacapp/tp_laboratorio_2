using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPractico1
{
     public class Calculadora
    {
       //Metodo Operar: Reliza la operacion matemática. Retorna un booleano. 
        public double Operar(Numero Ob1, Numero Ob2, string Operacion)  
        {
            switch(this.ValidarOperador(Operacion)){
                case "/":
                    {
                        if (Ob2.Numero1 != 0)
                        {

                            return Ob1.Numero1 / Ob2.Numero1;
                            break;
                        }
                        else
                        {
                            return 0;
                            break;
                        }

                       

                    }

                case "*":
                    {
                        return Ob1.Numero1 * Ob2.Numero1;
                        break;
                    }
                case "+":
                    {
                        return Ob1.Numero1 + Ob2.Numero1;
                        break;
                    }
                case "-":
                    {
                        return Ob1.Numero1 - Ob2.Numero1;
                        break;
                    }
               default:
                    {
                        return 0;
                        break;
                    }

            }

           

        }


         //Método privado: Valida el operador string.
        private string ValidarOperador(string Operacion)
        {
            if(Operacion=="*"||Operacion=="/" ||Operacion=="+"||Operacion=="-")
            {
                return Operacion;

            }
            else{

                return "+";
            }



        }
        
        

   }
    
}
