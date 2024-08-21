namespace SysPecNSDesk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConfirma = new Button();
            txtNumero2 = new TextBox();
            lstResultado = new ListBox();
            cmbOperacao = new ComboBox();
            txtNumero1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnConfirma
            // 
            btnConfirma.AccessibleName = "";
            btnConfirma.Enabled = false;
            btnConfirma.Location = new Point(375, 75);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(75, 23);
            btnConfirma.TabIndex = 0;
            btnConfirma.Text = "&Confirma";
            btnConfirma.UseVisualStyleBackColor = true;
            btnConfirma.Click += button1_Click;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(254, 75);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 1;
            txtNumero2.TextChanged += textBox1_TextChanged;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(144, 117);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(186, 199);
            lstResultado.TabIndex = 2;
            lstResultado.SelectedIndexChanged += lstResultado_SelectedIndexChanged;
            // 
            // cmbOperacao
            // 
            cmbOperacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacao.FormattingEnabled = true;
            cmbOperacao.Items.AddRange(new object[] { "Multiplicação", "Divisão", "Adição", "Subtração", "Exponenciação", "Radiciação", "Logaritmos" });
            cmbOperacao.Location = new Point(12, 75);
            cmbOperacao.Name = "cmbOperacao";
            cmbOperacao.Size = new Size(121, 23);
            cmbOperacao.TabIndex = 3;
            cmbOperacao.SelectedIndexChanged += cmbOperacao_SelectedIndexChanged;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(144, 75);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 4;
            txtNumero1.TextChanged += txtNumero1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 57);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 5;
            label1.Text = "1°Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 57);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 6;
            label2.Text = "2°Número";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 57);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Operação";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(474, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(580, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(686, 238);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumero1);
            Controls.Add(cmbOperacao);
            Controls.Add(lstResultado);
            Controls.Add(txtNumero2);
            Controls.Add(btnConfirma);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirma;
        private TextBox txtNumero2;
        private ListBox lstResultado;
        private ComboBox cmbOperacao;
        private TextBox txtNumero1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}
