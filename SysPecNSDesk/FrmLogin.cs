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

namespace SysPecNSDesk
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            if (txt_Email.Text != string.Empty && txt_Senha.Text != string.Empty)
            {
                var usuario = Usuario.EfetuarLogin(txt_Email.Text, txt_Senha.Text);
                if (usuario.Id > 0)
                {
                    if (usuario.Ativo)
                    {
                       Program.UsuarioLogado = usuario;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Seu usúario está inativo \n procure a gerencia.");
                        Application.Exit();

                    }
                }
                else
                {
                    MessageBox.Show("Email ou Senha inválida ou inexistentes. \n Se achar que isso é um erro, procure a gerência.");
                    Application.Exit();
                }

            }
            else
            {
                MessageBox.Show("Você deve preencher todos os campos");
            }
        }

     

      
    }
}     
