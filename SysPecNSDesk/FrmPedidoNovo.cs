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
        Produto produto;
        public FrmPedidoNovo()
        {
            InitializeComponent();
        }

        private void FrmPedidoNovo_Load(object sender, EventArgs e)
        {
            txt_Usuario.Text = Program.UsuarioLogado.Id + "-" + Program.UsuarioLogado.Nome;
        }



        private void txt_CodBar_Leave(object sender, EventArgs e)
        {
            if (txt_CodBar.TextLength > 0)
            {
                produto = Produto.ObterPorId(txt_CodBar.Text);
                txt_Descricao.Text = produto.Descricao;
                txt_ValorUnit.Text = produto.ValorUnit.ToString();
                txt_ValorUnit.ReadOnly = true;
                txt_Quantidade.Focus();

            }
        }

        private void btn_Insere_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(
             Program.UsuarioLogado,
             Cliente.ObterPorId(int.Parse(txt_IdCliente.Text)), 0
             );
            pedido.Inserir();
            txt_IdPedido.Text = pedido.ToString();
            grb_Itens.Enabled = true;
            grb_Identificacao.Enabled = false;
            txt_CodBar.Focus();
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            ItemPedido item = new(
                int.Parse(txt_IdPedido.Text),
                produto,
                produto.ValorUnit,
                double.Parse(txt_Quantidade.Text),
                double.Parse(txt_DescontoItens.Text)
                );
            item.Inserir();
            produto = new();
            txt_DescontoItens.Text = "0";
            txt_Descricao.Clear();
            txt_ValorUnit.Text = "1";
            txt_CodBar.Clear();
            txt_CodBar.Focus();

            PreencherGridItens();
        }

        private void PreencherGridItens()
        {
           var itens = ItemPedido.ObterListaPorPedido(int.Parse(txt_IdPedido.Text));
           dgv_ItensPedido.Rows.Clear();
            int linha = 0;
            foreach(var item in itens)
            {
                dgv_ItensPedido.Rows.Add();
                dgv_ItensPedido.Rows[linha].Cells[0].Value = item.Id;
                dgv_ItensPedido.Rows[linha].Cells[1].Value = item.Produto.CodBar;
                dgv_ItensPedido.Rows[linha].Cells[2].Value = item.Produto.Descricao;
                dgv_ItensPedido.Rows[linha].Cells[3].Value = item.ValorUnit;
                dgv_ItensPedido.Rows[linha].Cells[4].Value = item.Quantidade;
                dgv_ItensPedido.Rows[linha].Cells[5].Value = item.Desconto;
                dgv_ItensPedido.Rows[linha].Cells[6].Value = item.ValorUnit * item.Quantidade - item.Desconto;
            }
           
        }
    }
}
