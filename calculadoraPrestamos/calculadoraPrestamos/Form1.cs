namespace calculadoraPrestamos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(Monto.Text);
            double interes = double.Parse(Interes.Text);
            double plazo = double.Parse(Plazo.Text);


            double cuotaMensual = (monto * (interes * Math.Pow(1 + interes,plazo))) / (Math.Pow(1 + interes,plazo)-1);
            cuotaMensual = Math.Round(cuotaMensual / 2);
            RESULTADO.Text = cuotaMensual.ToString();


        }
    }
}
