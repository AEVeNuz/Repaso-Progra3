namespace RepasoPrimeraClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sumarbutton1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Numero1textBox1.Text); //Para convertir el texto en entero
            int num2 = Convert.ToInt32(Numero2textBox2.Text);

            ResultadotextBox3.Text = Sumar(num1, num2).ToString(); //Llamo a la función sumar con sus parámetros
        }

        private int Sumar(int num1, int num2) //Función, devulve un valor
        {
            int resultado = num1 + num2;
            return resultado;
        }

        private void MostrarMensaje() //Procedimiento, no devuelve ningún resultado
        {
            MessageBox.Show("Este es un mensaje"); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarMensaje(); //No recibe ningún parámetro, ni devulve ningún valor
        }

        //Variables
        //Procedimientos
        //Funciones




    }
}