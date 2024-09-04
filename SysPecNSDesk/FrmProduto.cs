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
            int count = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[count].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[count].Cells[1].Value = produto.CodBar;
                dgvProdutos.Rows[count].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[count].Cells[3].Value = produto.ValorUnit;
                dgvProdutos.Rows[count].Cells[4].Value = produto.EstoqueMinimo;
                dgvProdutos.Rows[count].Cells[5].Value = produto.ClasseDesconto;
                dgvProdutos.Rows[count].Cells[6].Value = produto.DataCad;
                dgvProdutos.Rows[count].Cells[7].Value = produto.ValorUnit;
                dgvProdutos.Rows[count].Cells[8].Value = produto.UnidadeVenda;

                count++;
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new(txt_CodBar.Text, txt_Descricao.Text,
            double.Parse(txt_ValorUnit.Text), gpb_Produtos.Text,
            Categoria.ObterPorId(Convert.ToInt32(cmb_Categoria.SelectedValue)),
            (int)np_EstoqueMinimo.Value, double.Parse(txt_Desconto.Text)
            );
            produto.Inserir();
            if (produto.Id > 0)
            {
                MessageBox.Show($"Produto gravado com sucesso com ID {produto.Id}");
                FrmProduto_Load(sender, e);
            }
        }
        private void LimpaControles()
        {
            txt_CodBar.Clear();
            txt_ValorUnit.Clear();
            txt_UnidadeVenda.Clear();
            txt_Descricao.Clear();
            txt_Desconto.Clear();
            np_EstoqueMinimo.Value = 0;
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            if (btn_Consultar.Text == "&Consultar")
            {
                txt_CodBar.Clear();
                txt_ValorUnit.Clear();
                txt_UnidadeVenda.Clear();
                txt_Descricao.Clear();
                txt_Desconto.Clear();
                np_EstoqueMinimo.Value = 0;
                btn_Consultar.Text = "&Obter por ID";
                txt_Id.Focus();
                txt_Id.ReadOnly = false;
            }
            else
            {
                if (txt_Id.Text.Length > 0)
                {
                    Produto produto = Produto.ObterPorId(int.Parse(txt_Id.Text));
                    txt_CodBar.Text = produto.CodBar;
                    txt_ValorUnit.Text = Convert.ToString(produto.ValorUnit);
                    txt_Descricao.Text = produto.Descricao;
                    txt_Desconto.Text = produto.ClasseDesconto.ToString();
                    txt_UnidadeVenda.Text = produto.UnidadeVenda;
                    //npEstoqueMinimo.Value = produto.EstoqueMinimo;
                    cmb_Categoria.SelectedIndex =
                    cmb_Categoria.FindString(produto.Categoria.Nome);
                    btn_Editar.Enabled = true;
                }
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Produto produto = new(
            int.Parse(txt_Id.Text),
            txt_CodBar.Text,
            txt_Descricao.Text,
            double.Parse(txt_ValorUnit.Text),
            txt_UnidadeVenda.Text,
            Categoria.ObterPorId(Convert.ToInt32(cmb_Categoria.SelectedValue)),
            (double)np_EstoqueMinimo.Value,
            double.Parse(txt_Desconto.Text),
            null,
            null
            );
            
            produto.Atualizar(); //grava as alterações no banco;
            MessageBox.Show($"Produto {produto.Id} - {produto.Descricao} atualizar com sucesso");
            btn_Editar.Enabled = false;
            txt_Id.ReadOnly = true;
            btn_Consultar.Text = "&Consultar";
            LimpaControles();
            FrmProduto_Load(sender, e);
        }

    }
}
