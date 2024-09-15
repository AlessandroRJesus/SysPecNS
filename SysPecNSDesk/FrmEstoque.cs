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
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            Estoque estoque = new(
               Convert.ToDouble(txt_Quantidade.Text),
               Data_Movimento.Value
                );
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                var msg = MessageBox.Show("sair do estoque?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (msg == DialogResult.No) this.Close();
            }
            else
            {
                Close();
            }
        }
        private bool VerificaControles()
        {
            if  (Convert.ToDouble(txt_Quantidade.Text) 
             || Data_Movimento.
             )
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
