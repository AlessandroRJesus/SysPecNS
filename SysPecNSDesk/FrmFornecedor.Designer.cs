namespace SysPecNSDesk
{
    partial class FrmFornecedor
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_Id = new TextBox();
            txt_RazaoSocial = new TextBox();
            txt_Fantasia = new TextBox();
            txt_Cnpj = new TextBox();
            txt_Contato = new TextBox();
            txt_Telefone = new TextBox();
            txt_Email = new TextBox();
            btn_inserir = new Button();
            btn_Cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 40);
            label1.TabIndex = 0;
            label1.Text = "Fornecedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 98);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 99);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Razão Social";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 97);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Fantasia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 154);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 4;
            label5.Text = "CNPJ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(238, 154);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 5;
            label6.Text = "Contato";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(412, 154);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 6;
            label7.Text = "Telefone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(57, 205);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 7;
            label8.Text = "Email";
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(57, 115);
            txt_Id.Name = "txt_Id";
            txt_Id.ReadOnly = true;
            txt_Id.Size = new Size(48, 23);
            txt_Id.TabIndex = 8;
            // 
            // txt_RazaoSocial
            // 
            txt_RazaoSocial.Location = new Point(111, 115);
            txt_RazaoSocial.Name = "txt_RazaoSocial";
            txt_RazaoSocial.Size = new Size(232, 23);
            txt_RazaoSocial.TabIndex = 9;
            // 
            // txt_Fantasia
            // 
            txt_Fantasia.Location = new Point(351, 115);
            txt_Fantasia.Name = "txt_Fantasia";
            txt_Fantasia.Size = new Size(245, 23);
            txt_Fantasia.TabIndex = 10;
            // 
            // txt_Cnpj
            // 
            txt_Cnpj.Location = new Point(57, 172);
            txt_Cnpj.Name = "txt_Cnpj";
            txt_Cnpj.Size = new Size(128, 23);
            txt_Cnpj.TabIndex = 11;
            // 
            // txt_Contato
            // 
            txt_Contato.Location = new Point(238, 172);
            txt_Contato.Name = "txt_Contato";
            txt_Contato.Size = new Size(135, 23);
            txt_Contato.TabIndex = 12;
            // 
            // txt_Telefone
            // 
            txt_Telefone.Location = new Point(412, 172);
            txt_Telefone.Name = "txt_Telefone";
            txt_Telefone.Size = new Size(137, 23);
            txt_Telefone.TabIndex = 13;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(57, 223);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(203, 23);
            txt_Email.TabIndex = 14;
            // 
            // btn_inserir
            // 
            btn_inserir.Location = new Point(302, 234);
            btn_inserir.Name = "btn_inserir";
            btn_inserir.Size = new Size(75, 23);
            btn_inserir.TabIndex = 15;
            btn_inserir.Text = "Inserir";
            btn_inserir.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(399, 234);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 23);
            btn_Cancelar.TabIndex = 16;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // FrmFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 450);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_inserir);
            Controls.Add(txt_Email);
            Controls.Add(txt_Telefone);
            Controls.Add(txt_Contato);
            Controls.Add(txt_Cnpj);
            Controls.Add(txt_Fantasia);
            Controls.Add(txt_RazaoSocial);
            Controls.Add(txt_Id);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmFornecedor";
            Text = "FrmFornecedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_Id;
        private TextBox txt_RazaoSocial;
        private TextBox txt_Fantasia;
        private TextBox txt_Cnpj;
        private TextBox txt_Contato;
        private TextBox txt_Telefone;
        private TextBox txt_Email;
        private Button btn_inserir;
        private Button btn_Cancelar;
    }
}