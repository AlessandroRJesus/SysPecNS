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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
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
            btn_Editar = new Button();
            btn_Inserir = new Button();
            DataNasc = new DateTimePicker();
            DataCad = new DateTimePicker();
            txt_Email = new TextBox();
            lbl_DataCad = new Label();
            txt_Telefone = new TextBox();
            txt_Cpf = new TextBox();
            txt_Nome = new TextBox();
            txt_ID = new TextBox();
            chk_Ativo = new CheckBox();
            lbl_DataNasc = new Label();
            lbl_Email = new Label();
            lbl_Telefone = new Label();
            lbl_CPF = new Label();
            lbl_Nome = new Label();
            lbl_ID = new Label();
            tabPage2 = new TabPage();
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
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            lbl_Endereco_Id = new TextBox();
            lbl = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Cliente).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(71, 13);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(548, 483);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgv_Cliente);
            tabPage1.Controls.Add(btn_Cancelar);
            tabPage1.Controls.Add(btn_Editar);
            tabPage1.Controls.Add(btn_Inserir);
            tabPage1.Controls.Add(DataNasc);
            tabPage1.Controls.Add(DataCad);
            tabPage1.Controls.Add(txt_Email);
            tabPage1.Controls.Add(lbl_DataCad);
            tabPage1.Controls.Add(txt_Telefone);
            tabPage1.Controls.Add(txt_Cpf);
            tabPage1.Controls.Add(txt_Nome);
            tabPage1.Controls.Add(txt_ID);
            tabPage1.Controls.Add(chk_Ativo);
            tabPage1.Controls.Add(lbl_DataNasc);
            tabPage1.Controls.Add(lbl_Email);
            tabPage1.Controls.Add(lbl_Telefone);
            tabPage1.Controls.Add(lbl_CPF);
            tabPage1.Controls.Add(lbl_Nome);
            tabPage1.Controls.Add(lbl_ID);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(540, 455);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_Cliente
            // 
            dgv_Cliente.AllowUserToAddRows = false;
            dgv_Cliente.AllowUserToDeleteRows = false;
            dgv_Cliente.BackgroundColor = Color.White;
            dgv_Cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cliente.Columns.AddRange(new DataGridViewColumn[] { clnID, clnNome, clnCpf, clnTelefone, clnEmail, clnDataNasc, clnDataCad, clnAtivo });
            dgv_Cliente.Location = new Point(6, 288);
            dgv_Cliente.Name = "dgv_Cliente";
            dgv_Cliente.ReadOnly = true;
            dgv_Cliente.RowHeadersVisible = false;
            dgv_Cliente.Size = new Size(534, 153);
            dgv_Cliente.TabIndex = 2;
            dgv_Cliente.CellContentClick += dgv_Clientes_CellContentClick;
            // 
            // clnID
            // 
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            clnID.Width = 50;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 150;
            // 
            // clnCpf
            // 
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
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
            btn_Cancelar.Image = Properties.Resources.Cancel;
            btn_Cancelar.Location = new Point(318, 228);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(65, 54);
            btn_Cancelar.TabIndex = 22;
            btn_Cancelar.Text = "&Cancelar";
            btn_Cancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Editar.Image = Properties.Resources.Edit;
            btn_Editar.Location = new Point(226, 228);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(65, 54);
            btn_Editar.TabIndex = 20;
            btn_Editar.Text = "&Editar";
            btn_Editar.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Inserir
            // 
            btn_Inserir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Inserir.Image = Properties.Resources.Add;
            btn_Inserir.Location = new Point(138, 228);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(65, 54);
            btn_Inserir.TabIndex = 19;
            btn_Inserir.Text = "&Inserir";
            btn_Inserir.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Inserir.UseVisualStyleBackColor = true;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // DataNasc
            // 
            DataNasc.Location = new Point(243, 153);
            DataNasc.Name = "DataNasc";
            DataNasc.Size = new Size(246, 23);
            DataNasc.TabIndex = 18;
            // 
            // DataCad
            // 
            DataCad.Location = new Point(243, 199);
            DataCad.Name = "DataCad";
            DataCad.Size = new Size(246, 23);
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
            lbl_DataCad.Location = new Point(243, 181);
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
            // txt_ID
            // 
            txt_ID.Location = new Point(58, 49);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(49, 23);
            txt_ID.TabIndex = 10;
            // 
            // chk_Ativo
            // 
            chk_Ativo.AutoSize = true;
            chk_Ativo.Location = new Point(412, 51);
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
            // tabPage2
            // 
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txt_Cidade);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txt_Complemento);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txt_Numero);
            tabPage2.Controls.Add(txt_Bairro);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txt_Logradouro);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(maskedTextBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(lbl_Endereco_Id);
            tabPage2.Controls.Add(lbl);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(540, 455);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Enderecos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(389, 111);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 16;
            label8.Text = "UF";
            // 
            // txt_Cidade
            // 
            txt_Cidade.Location = new Point(52, 181);
            txt_Cidade.Name = "txt_Cidade";
            txt_Cidade.Size = new Size(145, 23);
            txt_Cidade.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 163);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 13;
            label7.Text = "&Cidade";
            // 
            // txt_Complemento
            // 
            txt_Complemento.Location = new Point(204, 129);
            txt_Complemento.Name = "txt_Complemento";
            txt_Complemento.Size = new Size(179, 23);
            txt_Complemento.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(204, 111);
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
            txt_Logradouro.Location = new Point(52, 129);
            txt_Logradouro.Name = "txt_Logradouro";
            txt_Logradouro.Size = new Size(136, 23);
            txt_Logradouro.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 111);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "&Logradouro";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(333, 63);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(117, 23);
            maskedTextBox1.TabIndex = 4;
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
            // lbl_Endereco_Id
            // 
            lbl_Endereco_Id.Location = new Point(52, 63);
            lbl_Endereco_Id.Name = "lbl_Endereco_Id";
            lbl_Endereco_Id.Size = new Size(57, 23);
            lbl_Endereco_Id.TabIndex = 1;
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
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(92, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(630, 507);
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Rondônia (RO) ", "Acre (AC) ", "Amazonas (AM) ", "Roraima (RR) ", "Pará (PA) ", "Amapá (AP) ", "Tocantins (TO) ", "Maranhão (MA)", "Piauí (PI)", "Ceará (CE)", "Rio Grande do Norte (RN) ", "Paraíba (PB) ", "Pernambuco (PE) ", "Alagoas (AL)", "Sergipe (SE) ", "Bahia (BA) ", "Minas Gerais (MG) ", "Espírito Santo (ES) ", "Rio de Janeiro (RJ) ", "São Paulo (SP) ", "Paraná (PR) ", "Santa Catarina (SC) ", "Rio Grande do Sul (RS) ", "Mato Grosso do Sul (MS) ", "Mato Grosso (MT)", "Goiás (GO) ", "Distrito Federal (DF)  " });
            comboBox1.Location = new Point(389, 129);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
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
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Cliente).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label lbl_DataNasc;
        private Label lbl_Email;
        private Label lbl_Telefone;
        private Label lbl_CPF;
        private Label lbl_Nome;
        private Label lbl_ID;
        private CheckBox chk_Ativo;
        private TextBox txt_ID;
        private TextBox txt_Nome;
        private TextBox txt_Cpf;
        private Label lbl_DataCad;
        private TextBox txt_Telefone;
        private DateTimePicker DataNasc;
        private DateTimePicker DataCad;
        private TextBox txt_Email;
        private Button btn_Inserir;
        private Button btn_Cancelar;
        private Button btn_Editar;
        private DataGridView dgv_Cliente;
        private Label label1;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnDataNasc;
        private DataGridViewTextBoxColumn clnDataCad;
        private DataGridViewTextBoxColumn clnAtivo;
        private TextBox lbl_Endereco_Id;
        private Label lbl;
        private MaskedTextBox maskedTextBox1;
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
        private ComboBox comboBox1;
    }
}