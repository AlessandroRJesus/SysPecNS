namespace SysPecNSDesk
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbp_ClienteEndereco = new TabControl();
            tbc_Cliente = new TabPage();
            btn_Cadastro = new Button();
            txt_Busca = new TextBox();
            dgv_Cliente = new DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnDataNasc = new DataGridViewTextBoxColumn();
            clnDataCad = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            btn_Cancelar = new Button();
            btn_Inserir = new Button();
            DataNasc = new DateTimePicker();
            DataCad = new DateTimePicker();
            txt_Email = new TextBox();
            lbl_DataCad = new Label();
            txt_Telefone = new TextBox();
            txt_Cpf = new TextBox();
            txt_Nome = new TextBox();
            txt_IdCliente = new TextBox();
            chk_Ativo = new CheckBox();
            lbl_DataNasc = new Label();
            lbl_Email = new Label();
            lbl_Telefone = new Label();
            lbl_CPF = new Label();
            lbl_Nome = new Label();
            lbl_ID = new Label();
            tbc_Endereco = new TabPage();
            btn_InserirEndereco = new Button();
            label = new Label();
            cmb_TipoEndereco = new ComboBox();
            cmb_Uf = new ComboBox();
            label8 = new Label();
            txt_Cidade = new TextBox();
            label7 = new Label();
            txt_Complemento = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txt_Numero = new TextBox();
            txt_Bairro = new TextBox();
            label4 = new Label();
            txt_Logradouro = new TextBox();
            label3 = new Label();
            txt_Cep = new MaskedTextBox();
            label2 = new Label();
            txt_EnderecoId = new TextBox();
            lbl = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            tbp_ClienteEndereco.SuspendLayout();
            tbc_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Cliente).BeginInit();
            tbc_Endereco.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbp_ClienteEndereco
            // 
            tbp_ClienteEndereco.Controls.Add(tbc_Cliente);
            tbp_ClienteEndereco.Controls.Add(tbc_Endereco);
            tbp_ClienteEndereco.Location = new Point(53, 22);
            tbp_ClienteEndereco.Name = "tbp_ClienteEndereco";
            tbp_ClienteEndereco.SelectedIndex = 0;
            tbp_ClienteEndereco.Size = new Size(547, 457);
            tbp_ClienteEndereco.TabIndex = 0;
            // 
            // tbc_Cliente
            // 
            tbc_Cliente.Controls.Add(btn_Cadastro);
            tbc_Cliente.Controls.Add(txt_Busca);
            tbc_Cliente.Controls.Add(dgv_Cliente);
            tbc_Cliente.Controls.Add(btn_Cancelar);
            tbc_Cliente.Controls.Add(btn_Inserir);
            tbc_Cliente.Controls.Add(DataNasc);
            tbc_Cliente.Controls.Add(DataCad);
            tbc_Cliente.Controls.Add(txt_Email);
            tbc_Cliente.Controls.Add(lbl_DataCad);
            tbc_Cliente.Controls.Add(txt_Telefone);
            tbc_Cliente.Controls.Add(txt_Cpf);
            tbc_Cliente.Controls.Add(txt_Nome);
            tbc_Cliente.Controls.Add(txt_IdCliente);
            tbc_Cliente.Controls.Add(chk_Ativo);
            tbc_Cliente.Controls.Add(lbl_DataNasc);
            tbc_Cliente.Controls.Add(lbl_Email);
            tbc_Cliente.Controls.Add(lbl_Telefone);
            tbc_Cliente.Controls.Add(lbl_CPF);
            tbc_Cliente.Controls.Add(lbl_Nome);
            tbc_Cliente.Controls.Add(lbl_ID);
            tbc_Cliente.Location = new Point(4, 24);
            tbc_Cliente.Name = "tbc_Cliente";
            tbc_Cliente.Padding = new Padding(3);
            tbc_Cliente.Size = new Size(539, 429);
            tbc_Cliente.TabIndex = 0;
            tbc_Cliente.Text = "Dados Cliente";
            tbc_Cliente.UseVisualStyleBackColor = true;
            // 
            // btn_Cadastro
            // 
            btn_Cadastro.BackColor = Color.Transparent;
            btn_Cadastro.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cadastro.Location = new Point(278, 200);
            btn_Cadastro.Name = "btn_Cadastro";
            btn_Cadastro.Size = new Size(120, 29);
            btn_Cadastro.TabIndex = 24;
            btn_Cadastro.Text = "&Cadastro Endereço";
            btn_Cadastro.UseVisualStyleBackColor = false;
            // 
            // txt_Busca
            // 
            txt_Busca.Location = new Point(0, 254);
            txt_Busca.Name = "txt_Busca";
            txt_Busca.Size = new Size(539, 23);
            txt_Busca.TabIndex = 23;
            txt_Busca.TextChanged += txt_Busca_TextChanged;
            // 
            // dgv_Cliente
            // 
            dgv_Cliente.AllowUserToAddRows = false;
            dgv_Cliente.AllowUserToDeleteRows = false;
            dgv_Cliente.AllowUserToOrderColumns = true;
            dgv_Cliente.BackgroundColor = Color.White;
            dgv_Cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cliente.Columns.AddRange(new DataGridViewColumn[] { clnID, clnNome, clnCpf, clnTelefone, clnEmail, clnDataNasc, clnDataCad, clnAtivo });
            dgv_Cliente.Location = new Point(0, 273);
            dgv_Cliente.Name = "dgv_Cliente";
            dgv_Cliente.ReadOnly = true;
            dgv_Cliente.RowHeadersVisible = false;
            dgv_Cliente.Size = new Size(539, 153);
            dgv_Cliente.TabIndex = 2;
            dgv_Cliente.CellContentClick += dgv_Clientes_CellContentClick;
            // 
            // clnID
            // 
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            clnID.Width = 40;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 90;
            // 
            // clnCpf
            // 
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            clnCpf.Width = 60;
            // 
            // clnTelefone
            // 
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            // 
            // clnDataNasc
            // 
            clnDataNasc.HeaderText = "Data de Nascimento";
            clnDataNasc.Name = "clnDataNasc";
            clnDataNasc.ReadOnly = true;
            // 
            // clnDataCad
            // 
            clnDataCad.HeaderText = "Data de Cadastro";
            clnDataCad.Name = "clnDataCad";
            clnDataCad.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 50;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancelar.Location = new Point(419, 200);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(82, 29);
            btn_Cancelar.TabIndex = 22;
            btn_Cancelar.Text = "&Cancelar";
            btn_Cancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Inserir
            // 
            btn_Inserir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Inserir.Location = new Point(188, 200);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(74, 29);
            btn_Inserir.TabIndex = 19;
            btn_Inserir.Text = "&Inserir";
            btn_Inserir.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Inserir.UseVisualStyleBackColor = true;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // DataNasc
            // 
            DataNasc.Format = DateTimePickerFormat.Short;
            DataNasc.Location = new Point(243, 153);
            DataNasc.Name = "DataNasc";
            DataNasc.Size = new Size(99, 23);
            DataNasc.TabIndex = 18;
            // 
            // DataCad
            // 
            DataCad.Format = DateTimePickerFormat.Short;
            DataCad.Location = new Point(348, 153);
            DataCad.Name = "DataCad";
            DataCad.Size = new Size(99, 23);
            DataCad.TabIndex = 17;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(58, 101);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(254, 23);
            txt_Email.TabIndex = 16;
            // 
            // lbl_DataCad
            // 
            lbl_DataCad.AutoSize = true;
            lbl_DataCad.Location = new Point(348, 135);
            lbl_DataCad.Name = "lbl_DataCad";
            lbl_DataCad.Size = new Size(99, 15);
            lbl_DataCad.TabIndex = 15;
            lbl_DataCad.Text = "&Data Do Cadastro";
            // 
            // txt_Telefone
            // 
            txt_Telefone.Location = new Point(58, 152);
            txt_Telefone.Name = "txt_Telefone";
            txt_Telefone.Size = new Size(160, 23);
            txt_Telefone.TabIndex = 13;
            // 
            // txt_Cpf
            // 
            txt_Cpf.Location = new Point(318, 101);
            txt_Cpf.Name = "txt_Cpf";
            txt_Cpf.Size = new Size(160, 23);
            txt_Cpf.TabIndex = 12;
            // 
            // txt_Nome
            // 
            txt_Nome.Location = new Point(122, 49);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(269, 23);
            txt_Nome.TabIndex = 11;
            // 
            // txt_IdCliente
            // 
            txt_IdCliente.Location = new Point(58, 49);
            txt_IdCliente.Name = "txt_IdCliente";
            txt_IdCliente.ReadOnly = true;
            txt_IdCliente.Size = new Size(49, 23);
            txt_IdCliente.TabIndex = 10;
            // 
            // chk_Ativo
            // 
            chk_Ativo.AutoSize = true;
            chk_Ativo.Location = new Point(437, 49);
            chk_Ativo.Name = "chk_Ativo";
            chk_Ativo.Size = new Size(54, 19);
            chk_Ativo.TabIndex = 9;
            chk_Ativo.Text = "&Ativo";
            chk_Ativo.UseVisualStyleBackColor = true;
            // 
            // lbl_DataNasc
            // 
            lbl_DataNasc.AutoSize = true;
            lbl_DataNasc.Location = new Point(243, 135);
            lbl_DataNasc.Name = "lbl_DataNasc";
            lbl_DataNasc.Size = new Size(93, 15);
            lbl_DataNasc.TabIndex = 6;
            lbl_DataNasc.Text = "&Data Nacimento";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(68, 83);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(36, 15);
            lbl_Email.TabIndex = 5;
            lbl_Email.Text = "&Email";
            // 
            // lbl_Telefone
            // 
            lbl_Telefone.AutoSize = true;
            lbl_Telefone.Location = new Point(58, 134);
            lbl_Telefone.Name = "lbl_Telefone";
            lbl_Telefone.Size = new Size(51, 15);
            lbl_Telefone.TabIndex = 4;
            lbl_Telefone.Text = "T&elefone";
            // 
            // lbl_CPF
            // 
            lbl_CPF.AutoSize = true;
            lbl_CPF.Location = new Point(318, 83);
            lbl_CPF.Name = "lbl_CPF";
            lbl_CPF.Size = new Size(28, 15);
            lbl_CPF.TabIndex = 3;
            lbl_CPF.Text = "&CPF";
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Location = new Point(122, 31);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(96, 15);
            lbl_Nome.TabIndex = 2;
            lbl_Nome.Text = "&Nome Completo";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(58, 31);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(18, 15);
            lbl_ID.TabIndex = 1;
            lbl_ID.Text = "&ID";
            // 
            // tbc_Endereco
            // 
            tbc_Endereco.Controls.Add(btn_InserirEndereco);
            tbc_Endereco.Controls.Add(label);
            tbc_Endereco.Controls.Add(cmb_TipoEndereco);
            tbc_Endereco.Controls.Add(cmb_Uf);
            tbc_Endereco.Controls.Add(label8);
            tbc_Endereco.Controls.Add(txt_Cidade);
            tbc_Endereco.Controls.Add(label7);
            tbc_Endereco.Controls.Add(txt_Complemento);
            tbc_Endereco.Controls.Add(label6);
            tbc_Endereco.Controls.Add(label5);
            tbc_Endereco.Controls.Add(txt_Numero);
            tbc_Endereco.Controls.Add(txt_Bairro);
            tbc_Endereco.Controls.Add(label4);
            tbc_Endereco.Controls.Add(txt_Logradouro);
            tbc_Endereco.Controls.Add(label3);
            tbc_Endereco.Controls.Add(txt_Cep);
            tbc_Endereco.Controls.Add(label2);
            tbc_Endereco.Controls.Add(txt_EnderecoId);
            tbc_Endereco.Controls.Add(lbl);
            tbc_Endereco.Location = new Point(4, 24);
            tbc_Endereco.Name = "tbc_Endereco";
            tbc_Endereco.Padding = new Padding(3);
            tbc_Endereco.Size = new Size(539, 429);
            tbc_Endereco.TabIndex = 1;
            tbc_Endereco.Text = "Enderecos";
            tbc_Endereco.UseVisualStyleBackColor = true;
            // 
            // btn_InserirEndereco
            // 
            btn_InserirEndereco.Location = new Point(389, 169);
            btn_InserirEndereco.Name = "btn_InserirEndereco";
            btn_InserirEndereco.Size = new Size(90, 23);
            btn_InserirEndereco.TabIndex = 20;
            btn_InserirEndereco.Text = "&Inserir";
            btn_InserirEndereco.UseVisualStyleBackColor = true;
            btn_InserirEndereco.Click += btn_InserirEndereco_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(218, 151);
            label.Name = "label";
            label.Size = new Size(82, 15);
            label.TabIndex = 19;
            label.Text = "Tipo Endereço";
            // 
            // cmb_TipoEndereco
            // 
            cmb_TipoEndereco.FormattingEnabled = true;
            cmb_TipoEndereco.Location = new Point(218, 169);
            cmb_TipoEndereco.Name = "cmb_TipoEndereco";
            cmb_TipoEndereco.Size = new Size(143, 23);
            cmb_TipoEndereco.TabIndex = 18;
            // 
            // cmb_Uf
            // 
            cmb_Uf.FormattingEnabled = true;
            cmb_Uf.Items.AddRange(new object[] { "Rondônia (RO) ", "Acre (AC) ", "Amazonas (AM) ", "Roraima (RR) ", "Pará (PA) ", "Amapá (AP) ", "Tocantins (TO) ", "Maranhão (MA)", "Piauí (PI)", "Ceará (CE)", "Rio Grande do Norte (RN) ", "Paraíba (PB) ", "Pernambuco (PE) ", "Alagoas (AL)", "Sergipe (SE) ", "Bahia (BA) ", "Minas Gerais (MG) ", "Espírito Santo (ES) ", "Rio de Janeiro (RJ) ", "São Paulo (SP) ", "Paraná (PR) ", "Santa Catarina (SC) ", "Rio Grande do Sul (RS) ", "Mato Grosso do Sul (MS) ", "Mato Grosso (MT)", "Goiás (GO) ", "Distrito Federal (DF)  " });
            cmb_Uf.Location = new Point(389, 117);
            cmb_Uf.Name = "cmb_Uf";
            cmb_Uf.Size = new Size(121, 23);
            cmb_Uf.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(389, 99);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 16;
            label8.Text = "UF";
            // 
            // txt_Cidade
            // 
            txt_Cidade.Location = new Point(52, 169);
            txt_Cidade.Name = "txt_Cidade";
            txt_Cidade.Size = new Size(145, 23);
            txt_Cidade.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 151);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 13;
            label7.Text = "&Cidade";
            // 
            // txt_Complemento
            // 
            txt_Complemento.Location = new Point(204, 117);
            txt_Complemento.Name = "txt_Complemento";
            txt_Complemento.Size = new Size(179, 23);
            txt_Complemento.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(204, 99);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 11;
            label6.Text = "&Complemento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(465, 45);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 10;
            label5.Text = "&Numero";
            // 
            // txt_Numero
            // 
            txt_Numero.Location = new Point(465, 63);
            txt_Numero.Name = "txt_Numero";
            txt_Numero.Size = new Size(57, 23);
            txt_Numero.TabIndex = 9;
            // 
            // txt_Bairro
            // 
            txt_Bairro.Location = new Point(115, 63);
            txt_Bairro.Name = "txt_Bairro";
            txt_Bairro.Size = new Size(203, 23);
            txt_Bairro.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 45);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "&Bairro";
            // 
            // txt_Logradouro
            // 
            txt_Logradouro.Location = new Point(52, 117);
            txt_Logradouro.Name = "txt_Logradouro";
            txt_Logradouro.Size = new Size(136, 23);
            txt_Logradouro.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 99);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "&Logradouro";
            // 
            // txt_Cep
            // 
            txt_Cep.Location = new Point(333, 63);
            txt_Cep.Name = "txt_Cep";
            txt_Cep.Size = new Size(117, 23);
            txt_Cep.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 45);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "&CEP";
            // 
            // txt_EnderecoId
            // 
            txt_EnderecoId.Location = new Point(52, 63);
            txt_EnderecoId.Name = "txt_EnderecoId";
            txt_EnderecoId.ReadOnly = true;
            txt_EnderecoId.Size = new Size(57, 23);
            txt_EnderecoId.TabIndex = 1;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(52, 45);
            lbl.Name = "lbl";
            lbl.Size = new Size(18, 15);
            lbl.TabIndex = 0;
            lbl.Text = "&ID";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Aqua;
            groupBox1.Controls.Add(tbp_ClienteEndereco);
            groupBox1.Location = new Point(83, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(662, 497);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente e Enderecos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 9);
            label1.Name = "label1";
            label1.Size = new Size(321, 36);
            label1.TabIndex = 2;
            label1.Text = "Cliente e Endereço";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(800, 597);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            tbp_ClienteEndereco.ResumeLayout(false);
            tbc_Cliente.ResumeLayout(false);
            tbc_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Cliente).EndInit();
            tbc_Endereco.ResumeLayout(false);
            tbc_Endereco.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tbp_ClienteEndereco;
        private TabPage tbc_Cliente;
        private TabPage tbc_Endereco;
        private GroupBox groupBox1;
        private Label lbl_DataNasc;
        private Label lbl_Email;
        private Label lbl_Telefone;
        private Label lbl_CPF;
        private Label lbl_Nome;
        private Label lbl_ID;
        private CheckBox chk_Ativo;
        private TextBox txt_IdCliente;
        private TextBox txt_Nome;
        private TextBox txt_Cpf;
        private Label lbl_DataCad;
        private TextBox txt_Telefone;
        private DateTimePicker DataNasc;
        private DateTimePicker DataCad;
        private TextBox txt_Email;
        private Button btn_Inserir;
        private Button btn_Cancelar;
        private DataGridView dgv_Cliente;
        private Label label1;
        private TextBox txt_EnderecoId;
        private Label lbl;
        private MaskedTextBox txt_Cep;
        private Label label2;
        private TextBox txt_Numero;
        private TextBox txt_Bairro;
        private Label label4;
        private TextBox txt_Logradouro;
        private Label label3;
        private Label label5;
        private TextBox txt_Cidade;
        private Label label7;
        private TextBox txt_Complemento;
        private Label label6;
        private Label label8;
        private ComboBox cmb_Uf;
        private TextBox txt_Busca;
        private Label label;
        private ComboBox cmb_TipoEndereco;
        private Button btn_InserirEndereco;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnDataNasc;
        private DataGridViewTextBoxColumn clnDataCad;
        private DataGridViewTextBoxColumn clnAtivo;
        private Button btn_Cadastro;
    }
}