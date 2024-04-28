namespace calculadorCAPITAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double capitalInicialTextBox = double.Parse(capitalInicial.Text);


          
            double TasaInteresTextBox = double.Parse(textBox2.Text);



            double tiempoTextBox = double.Parse(textBox3.Text);


            double operacionCapital = capitalInicialTextBox * (Math.Pow( TasaInteresTextBox+1,tiempoTextBox));

            textBox1.Text = operacionCapital.ToString();

           
        }
    }
}
