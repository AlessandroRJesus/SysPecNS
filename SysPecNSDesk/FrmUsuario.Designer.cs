namespace SysPecNSDesk
{
    partial class FrmUsuario
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
            dgvUsuarios = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            btn_Inserir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_ID = new TextBox();
            txt_Nome = new TextBox();
            txt_Email = new TextBox();
            cmbNivel = new ComboBox();
            label6 = new Label();
            txt_Senha = new TextBox();
            txt_confirma_senha = new TextBox();
            chkAtivo = new CheckBox();
            btn_editar = new Button();
            btn_Deletar = new Button();
            txt_Busca = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnNivel, clnAtivo });
            dgvUsuarios.Location = new Point(33, 314);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(500, 124);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 150;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 150;
            // 
            // clnNivel
            // 
            clnNivel.Frozen = true;
            clnNivel.HeaderText = "Nivel";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 50;
            // 
            // btn_Inserir
            // 
            btn_Inserir.Location = new Point(88, 235);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(75, 23);
            btn_Inserir.TabIndex = 1;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.UseVisualStyleBackColor = true;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 75);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 75);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 119);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 119);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 5;
            label4.Text = "Nivel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 172);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 6;
            label5.Text = "Senha";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(88, 90);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(60, 23);
            txt_ID.TabIndex = 7;
            // 
            // txt_Nome
            // 
            txt_Nome.Location = new Point(154, 90);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(245, 23);
            txt_Nome.TabIndex = 8;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(88, 134);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(198, 23);
            txt_Email.TabIndex = 9;
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(299, 134);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(109, 23);
            cmbNivel.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(198, 172);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 11;
            label6.Text = "Confirmar Senha";
            // 
            // txt_Senha
            // 
            txt_Senha.Location = new Point(88, 190);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.Size = new Size(104, 23);
            txt_Senha.TabIndex = 12;
            txt_Senha.UseSystemPasswordChar = true;
            // 
            // txt_confirma_senha
            // 
            txt_confirma_senha.Location = new Point(198, 190);
            txt_confirma_senha.Name = "txt_confirma_senha";
            txt_confirma_senha.Size = new Size(100, 23);
            txt_confirma_senha.TabIndex = 13;
            txt_confirma_senha.UseSystemPasswordChar = true;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(316, 190);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 14;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(207, 235);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(75, 23);
            btn_editar.TabIndex = 15;
            btn_editar.Text = "&Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_Deletar
            // 
            btn_Deletar.Location = new Point(338, 236);
            btn_Deletar.Name = "btn_Deletar";
            btn_Deletar.Size = new Size(75, 23);
            btn_Deletar.TabIndex = 16;
            btn_Deletar.Text = "De&letar";
            btn_Deletar.UseVisualStyleBackColor = true;
            // 
            // txt_Busca
            // 
            txt_Busca.Location = new Point(33, 288);
            txt_Busca.Name = "txt_Busca";
            txt_Busca.Size = new Size(500, 23);
            txt_Busca.TabIndex = 17;
            txt_Busca.TextChanged += txt_Busca_TextChanged;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 450);
            Controls.Add(txt_Busca);
            Controls.Add(btn_Deletar);
            Controls.Add(btn_editar);
            Controls.Add(chkAtivo);
            Controls.Add(txt_confirma_senha);
            Controls.Add(txt_Senha);
            Controls.Add(label6);
            Controls.Add(cmbNivel);
            Controls.Add(txt_Email);
            Controls.Add(txt_Nome);
            Controls.Add(txt_ID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Inserir);
            Controls.Add(dgvUsuarios);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewCheckBoxColumn clnAtivo;
        private Button btn_Inserir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_ID;
        private TextBox txt_Nome;
        private TextBox txt_Email;
        private ComboBox cmbNivel;
        private Label label6;
        private TextBox txt_Senha;
        private TextBox txt_confirma_senha;
        private CheckBox chkAtivo;
        private Button btn_editar;
        private Button btn_Deletar;
        private TextBox txt_Busca;
    }
}