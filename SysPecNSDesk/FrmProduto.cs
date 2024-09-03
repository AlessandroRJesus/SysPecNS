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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void cmb_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

            //Carregando o combobox de niveis
            var Categorias = Categoria.ObterLista();
            cmb_Categoria.DataSource = Categorias;
            cmb_Categoria.DisplayMember = "Nome";
            cmb_Categoria.ValueMember = "Id";

            var lista = Produto.ObterLista();
            dgvProdutos.Rows.Add();
            int Count = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[Count].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[Count].Cells[1].Value = produto.CodBar;
                dgvProdutos.Rows[Count].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[Count].Cells[3].Value = produto.ValorUnit;
                dgvProdutos.Rows[Count].Cells[4].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[Count].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[Count].Cells[6].Value = produto.EstoqueMinimo;
                dgvProdutos.Rows[Count].Cells[7].Value = produto.ClasseDesconto;
                dgvProdutos.Rows[Count].Cells[8].Value = produto.DataCad;

                Count++;
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new(txt_CodBar.Text,txt_Descricao.Text, 
            double.Parse(txt_ValorUnit.Text),txt_UnidadeVenda.Text,
            Categoria.ObterPorId(Convert.ToInt32(cmb_Categoria.SelectedValue)),
            (int)np_EstoqueMinimo.Value,double.Parse(txt_Desconto.Text)
                );
            produto.Inserir();
            if(produto.Id>0)
            {
                MessageBox.Show($"Produto gravado com sucesso com ID {produto.Id}");
                FrmProduto_Load(sender, e);
            }
        }
    }
}
