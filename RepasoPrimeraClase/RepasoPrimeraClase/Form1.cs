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

            ResultadotextBox3.Text = Sumar(num1, num2).ToString(); //Llamo a la funci�n sumar con sus par�metros
        }

        private int Sumar(int num1, int num2) //Funci�n, devulve un valor
        {
            int resultado = num1 + num2;
            return resultado;
        }

        private void MostrarMensaje() //Procedimiento, no devuelve ning�n resultado
        {
            MessageBox.Show("Este es un mensaje"); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarMensaje(); //No recibe ning�n par�metro, ni devulve ning�n valor
        }

        //Variables
        //Procedimientos
        //Funciones




    }
}