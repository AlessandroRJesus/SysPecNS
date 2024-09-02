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
                DataCad.Value,
                DataNasc.Value =DateTime.Now
                );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                txt_ID.Text = cliente.Id.ToString();
                MessageBox.Show($"O Cliente {cliente.Nome},Foi inserido com sucesso, com o ID {cliente.Id}");
                txt_ID.Clear();
                txt_Nome.Clear();
                txt_Email.Clear();
                txt_Cpf.Clear();
                txt_Telefone.Clear(); 
                txt_Nome.Focus();
            }
            else
            {
                MessageBox.Show("Falha ao gravar o cliente!");
            }
        }

       
    }
}
