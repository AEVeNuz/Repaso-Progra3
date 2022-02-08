using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoPrimeraClase
{
    public partial class FuncionesTexto : Form
    {
        public FuncionesTexto()
        {
            InitializeComponent();
        }

        private void Procesarbutton1_Click(object sender, EventArgs e)
        {
            string cadena = cadenatextBox2.Text;

            LongitudtextBox1.Text = cadena.Length.ToString(); //Devuelve cantidad de valores enteros que el usuario ingresó

            PrimercaractertextBox1.Text = cadena.Substring(0, 1); //Devuelve el primer caracter
            
            UltimocaractertextBox1.Text = cadena.Substring(cadena.Length -1, 1); //Devuelve el último caracter
            
            RangotextBox1.Text = cadena.Substring(1, 5);
            
            MayusculatextBox1.Text = cadena.ToUpper(); //Convierte a mayúsculas
            
            MinusculatextBox1.Text =cadena.ToLower(); //Convierte a minúsculas
            
            ReemplazartextBox1.Text = cadena.Replace(" ", ""); //Para reemplazar caracteres


        }
    }
}
