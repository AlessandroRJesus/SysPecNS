using SysPecNSLib;

namespace SysPecNSDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Ol� TI96");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero2.Text.Length > 0)
            {
                btnConfirma.Enabled = true;
            }
            else
            {
                btnConfirma.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string operacao = cmbOperacao.Text;
            int posicaoOperacao = cmbOperacao.SelectedIndex;
            double numero1 = 0;
            if (txtNumero1.Text != string.Empty)
            {
                numero1 = Convert.ToDouble(txtNumero1.Text);
            }
            double numero2 = 0;
            if (posicaoOperacao < 5)
            {
                if (txtNumero2.Text != string.Empty)
                {
                    numero2 = Convert.ToDouble(txtNumero2.Text);
                }
            }
            double resultado = 0;
            switch (posicaoOperacao)
            {
                case 0:
                    resultado = numero1 * numero2;
                    break;
                case 1:
                    resultado = numero1 / numero2;
                    break;
                case 2:
                    resultado = numero1 + numero2;
                    break;
                case 3:
                    resultado = numero1 - numero2;
                    break;
                case 4:
                    resultado = Math.Pow(numero1, numero2);
                    break;
                case 5:
                    resultado = Math.Sqrt(numero1);
                    break;
                case 6:
                    resultado = Math.Log(numero1);
                    break;
                default:
                    break;

            }


            lstResultado.Items.Add($"{operacao} - {posicaoOperacao} = {resultado}");
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperacao.Focus();
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Length > 0 && cmbOperacao.SelectedIndex > 4)
            {
                btnConfirma.Enabled = true;
            }
        }

        private void cmbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOperacao.SelectedIndex > 4)
            {
                txtNumero2.Enabled = false;
            }
            else
            {
                txtNumero2.Enabled = true;
            }
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero1.Focus();
            btnConfirma.Enabled = false;
        }

        private void lstResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(textBox1.Text, textBox2.Text);
            nivel.Inserir();
            MessageBox.Show("Nivel gravado com sucesso !!!!!!!!!");
            button1.Enabled = false;
        }


        //existem 3 tipos de convers�o no c#
        // CAST
        //PARSE
        // CONVERT
        //int numero =Convert.ToInt32 (txtNumero2.Text);
        //for (int i = 0; i < 10; i++) 
        //{
        //lstResultado.Items.Add($"{numero} x {i+1}= {numero * (i+1)}");
        //}

    }
}
