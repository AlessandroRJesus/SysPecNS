using MySqlX.XDevAPI;
using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

        //btn_inserir serve para inserir os clientes no Banco de dados
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
                txt_EnderecoId.Text = cliente.Id.ToString();
            }
            else
            {
                MessageBox.Show("Falha ao gravar o cliente!");
            }

        }



        //Botão para decidir se vai continuar o cadastro ou não do cliente
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

        //Se o cliente não preencher nenhum campo ele o sistema vai entender que é nulo  
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
        //carregarGrid serve para salvar na tabela os campos do cliente
        private void CarregaGrid(string nome = "")
        {
            // Preenchendo o datagrid com os campos do Cliente
            var lista = Cliente.ObterLista(nome);
            dgv_Cliente.Rows.Clear();
            int cont = 0;
            foreach (var cliente in lista)
            {
                dgv_Cliente.Rows.Add();
                dgv_Cliente.Rows[cont].Cells[0].Value = cliente.Id;
                dgv_Cliente.Rows[cont].Cells[1].Value = cliente.Nome;
                dgv_Cliente.Rows[cont].Cells[2].Value = cliente.Cpf;
                dgv_Cliente.Rows[cont].Cells[3].Value = cliente.Telefone;
                dgv_Cliente.Rows[cont].Cells[4].Value = cliente.Email;
                dgv_Cliente.Rows[cont].Cells[5].Value = cliente.Data_nasc;
                dgv_Cliente.Rows[cont].Cells[6].Value = cliente.Data_cad;
                dgv_Cliente.Rows[cont].Cells[7].Value = cliente.Ativo;

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
            Endereco endereco = new(
                Cliente.ObterPorId(int.Parse(txt_EnderecoId.Text)),
                txt_Cep.Text,
                txt_Logradouro.Text,
                txt_Numero.Text,
                txt_Complemento.Text,
                txt_Bairro.Text,
                txt_Cidade.Text,
                cmb_Uf.Text,
                cmb_TipoEndereco.Text
                );
            endereco.Inserir();
            if (endereco.Id > 0)
            {
                txt_IdCliente.Text = endereco.Id.ToString();
                MessageBox.Show($"O Endereço, Foi inserido com sucesso, com o ID do cliente{endereco.Id}");
                txt_Cep.Clear();
                txt_Logradouro.Clear();
                txt_Numero.Clear();
                txt_Complemento.Clear();
                txt_Bairro.Clear();
                txt_Cidade.Clear();
                cmb_Uf.Focus();
                cmb_TipoEndereco.Focus();
                txt_EnderecoId.Text = endereco.Id.ToString();
            }
            else
            {
                MessageBox.Show("Falha ao gravar o endereço do cliente!");
            }

        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            this.tbp_Endereco.SelectedTab = tbc_Endereco;

        }

        private void tbc_Endereco_Click(object sender, EventArgs e)
        {

        }
    }

}

