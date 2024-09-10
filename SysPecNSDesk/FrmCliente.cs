using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SysPecNSDesk
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {

            Cliente cliente = new(
                txt_Nome.Text,
                txt_Cpf.Text,
                txt_Telefone.Text,
                txt_Email.Text,
                DataCad.Value,
                DataNasc.Value = DateTime.Now
                );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                txt_IdCliente.Text = cliente.Id.ToString();
                MessageBox.Show($"O Cliente {cliente.Nome},Foi inserido com sucesso, com o ID {cliente.Id}");
                txt_IdCliente.Clear();
                txt_Nome.Clear();
                txt_Cpf.Clear();
                txt_Telefone.Clear();
                txt_Email.Clear();
                txt_Nome.Focus();

            }
            else
            {
                MessageBox.Show("Falha ao gravar o cliente!");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                var msg = MessageBox.Show("Deseja continuar o cadastro?", "cadastro de usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (msg == DialogResult.No) this.Close();
            }
            else
            {
                Close();
            }
        }
        private bool VerificaControles()
        {
            if (txt_Nome.Text != string.Empty
             || txt_Cpf.Text != string.Empty
             || txt_Telefone.Text != string.Empty
             || txt_Email.Text != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CarregaGrid(string nome = "")
        {
            // Preenchendo o datagrid com os Cliente
            var lista = Cliente.ObterLista(nome);
            dgv_Cliente.Rows.Clear();
            int cont = 0;
            foreach (var clinte in lista)
            {
                dgv_Cliente.Rows.Add();
                dgv_Cliente.Rows[cont].Cells[0].Value = clinte.Id;
                dgv_Cliente.Rows[cont].Cells[1].Value = clinte.Nome;
                dgv_Cliente.Rows[cont].Cells[2].Value = clinte.Cpf;
                dgv_Cliente.Rows[cont].Cells[3].Value = clinte.Telefone;
                dgv_Cliente.Rows[cont].Cells[4].Value = clinte.Email;
                dgv_Cliente.Rows[cont].Cells[5].Value = clinte.Data_nasc;
                dgv_Cliente.Rows[cont].Cells[6].Value = clinte.Data_cad;
                dgv_Cliente.Rows[cont].Cells[7].Value = clinte.Ativo;

                cont++;
            }
        }

        private void dgv_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int posicaoLinha = dgv_Cliente.CurrentRow.Index;
            id = Convert.ToInt32(dgv_Cliente.Rows[posicaoLinha].Cells[0].Value);
            MessageBox.Show(id.ToString());
        }

        private void txt_Busca_TextChanged(object sender, EventArgs e)
        {
            if (txt_Busca.Text.Length > 0)
            {
                CarregaGrid(txt_Busca.Text);
            }
            else
            {
                CarregaGrid();
            }
        }

        private void btn_InserirEndereco_Click(object sender, EventArgs e)
        {
           
        }
    }
    
}

