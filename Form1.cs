namespace Operaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbOperaciones.Items.Add("Suma");
            this.cmbOperaciones.Items.Add("Resta");
            this.cmbOperaciones.Items.Add("Divisi�n");
            this.cmbOperaciones.Items.Add("Multiplicaci�n");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (this.cmbOperaciones.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una operaci�n antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtNum1.Text) || string.IsNullOrWhiteSpace(this.txtNum2.Text))
            {
                MessageBox.Show("Por favor, ingrese ambos n�meros antes de calcular.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!NumeroValido(this.txtNum1.Text) || !NumeroValido(this.txtNum2.Text))
            {
                MessageBox.Show("Ingrese valores num�ricos v�lidos en ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double resultado=0;
            string operacion = this.cmbOperaciones.SelectedItem.ToString();

            switch (operacion)
            {
                case "Suma":
                    resultado = double.Parse(this.txtNum1.Text) + double.Parse(this.txtNum2.Text);
                    break;
                case "Resta":
                    resultado = double.Parse(this.txtNum1.Text) - double.Parse(this.txtNum2.Text);
                    break;
                case "Divisi�n":
                    resultado = double.Parse(this.txtNum1.Text) / double.Parse(this.txtNum2.Text);
                    break;
                case "Multiplicaci�n":
                    resultado = double.Parse(this.txtNum1.Text) * double.Parse(this.txtNum2.Text);
                    break;
                default:
                    break;
            }
            this.txtResultado.Text=resultado.ToString("0.##");
        }
        private bool NumeroValido(string input)
        {
            return int.TryParse(input, out _);
        }
    }
    //Vanesa Medina Morales 4�A
}
