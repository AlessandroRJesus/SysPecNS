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
                txt_Cpf.Text,
                txt_Telefone.Text,
                txt_Email.Text,
                DataCad.Value,
                DataNasc.Value = DateTime.Now
                );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                txt_ID.Text = cliente.Id.ToString();
                MessageBox.Show($"O Cliente {cliente.Nome},Foi inserido com sucesso, com o ID {cliente.Id}");
                txt_ID.Clear();
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
    }
}