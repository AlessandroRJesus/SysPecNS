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
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(115, 34);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(548, 351);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            tabPage1.Size = new Size(540, 323);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancelar.Image = Properties.Resources.Cancel;
            btn_Cancelar.Location = new Point(306, 240);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(65, 54);
            btn_Cancelar.TabIndex = 22;
            btn_Cancelar.Text = "&Cancelar";
            btn_Cancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            btn_Editar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Editar.Image = Properties.Resources.Edit;
            btn_Editar.Location = new Point(214, 240);
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
            btn_Inserir.Location = new Point(126, 240);
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
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(540, 323);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Enderecos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(146, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(1, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 428);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label lbl_DataNasc;
        private Label lbl_Email;
        private Label lbl_Telefone;
        private Label lbl_CPF;
        private Label lbl_Nome;
        private Label lbl_ID;
        private DataGridView dataGridView1;
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
    }
}