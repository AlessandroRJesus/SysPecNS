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
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            textBox7 = new TextBox();
            lbl_DataCad = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
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
            tabControl1.Size = new Size(545, 351);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(textBox7);
            tabPage1.Controls.Add(lbl_DataCad);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox1);
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
            tabPage1.Size = new Size(537, 323);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(72, 176);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(246, 23);
            dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(72, 237);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(246, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(235, 121);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(174, 23);
            textBox7.TabIndex = 16;
            // 
            // lbl_DataCad
            // 
            lbl_DataCad.AutoSize = true;
            lbl_DataCad.Location = new Point(72, 219);
            lbl_DataCad.Name = "lbl_DataCad";
            lbl_DataCad.Size = new Size(99, 15);
            lbl_DataCad.TabIndex = 15;
            lbl_DataCad.Text = "&Data Do Cadastro";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(382, 60);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(141, 23);
            textBox5.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(72, 121);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(137, 23);
            textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(49, 23);
            textBox1.TabIndex = 10;
            // 
            // chk_Ativo
            // 
            chk_Ativo.AutoSize = true;
            chk_Ativo.Location = new Point(444, 121);
            chk_Ativo.Name = "chk_Ativo";
            chk_Ativo.Size = new Size(54, 19);
            chk_Ativo.TabIndex = 9;
            chk_Ativo.Text = "&Ativo";
            chk_Ativo.UseVisualStyleBackColor = true;
            // 
            // lbl_DataNasc
            // 
            lbl_DataNasc.AutoSize = true;
            lbl_DataNasc.Location = new Point(72, 158);
            lbl_DataNasc.Name = "lbl_DataNasc";
            lbl_DataNasc.Size = new Size(93, 15);
            lbl_DataNasc.TabIndex = 6;
            lbl_DataNasc.Text = "&Data Nacimento";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(235, 103);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(36, 15);
            lbl_Email.TabIndex = 5;
            lbl_Email.Text = "&Email";
            // 
            // lbl_Telefone
            // 
            lbl_Telefone.AutoSize = true;
            lbl_Telefone.Location = new Point(382, 42);
            lbl_Telefone.Name = "lbl_Telefone";
            lbl_Telefone.Size = new Size(51, 15);
            lbl_Telefone.TabIndex = 4;
            lbl_Telefone.Text = "T&elefone";
            // 
            // lbl_CPF
            // 
            lbl_CPF.AutoSize = true;
            lbl_CPF.Location = new Point(72, 103);
            lbl_CPF.Name = "lbl_CPF";
            lbl_CPF.Size = new Size(28, 15);
            lbl_CPF.TabIndex = 3;
            lbl_CPF.Text = "&CPF";
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Location = new Point(136, 42);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(96, 15);
            lbl_Nome.TabIndex = 2;
            lbl_Nome.Text = "&Nome Completo";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(72, 42);
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
            tabPage2.Size = new Size(775, 385);
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
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lbl_DataCad;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox7;
    }
}