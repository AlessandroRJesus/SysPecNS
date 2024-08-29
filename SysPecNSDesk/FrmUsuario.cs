using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SysPecNSDesk
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }


        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            //Carregando o combobox de niveis
            var niveis = Nivel.ObterLista();
            cmbNivel.DataSource = niveis;
            cmbNivel.DisplayMember = "Nome";
            cmbNivel.ValueMember = "Id";
            CarregaGrid();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new(
                txt_Nome.Text,
                txt_Email.Text,
                txt_Senha.Text,
                Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue))
                );
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                txt_ID.Text = usuario.Id.ToString();
                MessageBox.Show($"O usuário {usuario.Nome}," +
                    $"Foi inserido com sucesso, com o ID {usuario.Id}");
                txt_ID.Clear();
                txt_Nome.Clear();
                txt_Email.Clear();
                txt_confirma_senha.Clear();
                txt_Senha.Clear();
                txt_Nome.Focus();
                FrmUsuario_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao gravar o usuário!");
            }
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
        private void CarregaGrid(string nome = "")
        {
            // Preenchendo o datagrid com os usuários
            var lista = Usuario.ObterLista(nome);
            dgvUsuarios.Rows.Clear();
            int cont = 0;
            foreach (var usuario in lista)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[cont].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[cont].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[cont].Cells[3].Value = usuario.Nivel.Nome;
                dgvUsuarios.Rows[cont].Cells[4].Value = usuario.Ativo;

                cont++;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                var msg = MessageBox.Show("Deseja continuar o cadastro?", "cadastro de usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (msg == DialogResult.Yes) this.Close();
            }
            else
            {
                Close();
            }

        }
        private bool VerificaControles()
        {
            if (txt_Nome.Text != string.Empty
             || txt_Email.Text != string.Empty
             || txt_Senha.Text != string.Empty
             || txt_confirma_senha.Text != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int posicaoLinha = dgvUsuarios.CurrentRow.Index;
            id = Convert.ToInt32(dgvUsuarios.Rows[posicaoLinha].Cells[0].Value);
            MessageBox.Show(id.ToString());
        }
    }
}

