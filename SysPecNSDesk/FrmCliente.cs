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
                txt_Email.Text,
                txt_Cpf.Text,
                txt_Telefone.Text,
                txt_DateNasc.Text,

              
                Cliente.ObterPorId(Convert.ToInt32(cmbcliente.SelectedValue))
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
    }
}
