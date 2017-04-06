using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPractico1;

namespace PlataformaV
{
    public partial class Form1 : Form
    {
        public Numero Operando; //Atributo de tipo Numero
        public Numero Operador; //Atributo de tipo Numero
        public Calculadora Resultado;//Atributo de tipo Calculadora
        public string Operatoria; //Atributo de tipo string
        public double Result; //Atributo de tipo double

        public Form1() //Constructor
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Asiga valor al Operando ingresado por el Usuario
        {
            this.Operando = new Numero(this.textBox1.Text);
        }
       

        private void textBox2_TextChanged(object sender, EventArgs e) //Asigna valor al operador ingresado por el Usuario
        {
            this.Operador = new Numero(this.textBox2.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//Asigna valor a Operatoria ingresado por el Usuario
        {
            this.Operatoria=this.comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e) //Funcion limpiar: Restablece los valores iniciales de cada componente
        {
            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.comboBox1.ResetText();
            label2.Text = "0";

        }

        private void label2_Click(object sender, EventArgs e) //Muestra el resultado devuelto por el método Operar y guardado en el atributo de tipo double result
        {
            
            label2.Text = System.Convert.ToString(this.Result);
            //label1.Text = System.Convert.ToString(this.comboBox1.Text);
          
        }

        private void button2_Click(object sender, EventArgs e) //Llama al resto de las funciones, instancia el objeto Calculadora, y llama a la funcion operar. 
        {   textBox1_TextChanged( sender, e);
            textBox2_TextChanged (sender, e);
            comboBox1_SelectedIndexChanged(sender, e);
            Resultado = new Calculadora();
            this.Result = this.Resultado.Operar(this.Operando, this.Operador, this.Operatoria);
            label2_Click(sender, e);
        }

        




    }
}
