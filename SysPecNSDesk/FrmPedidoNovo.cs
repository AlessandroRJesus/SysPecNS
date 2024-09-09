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
    public partial class FrmPedidoNovo : Form
    {
        public FrmPedidoNovo()
        {
            InitializeComponent();
        }

        private void FrmPedidoNovo_Load(object sender, EventArgs e)
        {
            txt_Usuario.Text = Program.UsuarioLogado.Id + "-" + Program.UsuarioLogado.Nome;
        }

        private void btn_InserirPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(
              Program.UsuarioLogado,
              Cliente.ObterPorId(int.Parse(txt_Cliente.Text)),0  
              );
            MessageBox.Show($"Novo pedido criado - {pedido.Id}");
        }
    }
}
