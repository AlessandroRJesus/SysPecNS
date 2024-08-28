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
            lbl_ID = new Label();
            lbl_Email = new Label();
            lbl_CPF = new Label();
            button1 = new Button();
            lbl_Nome = new Label();
            lbl_DataNasc = new Label();
            lbl_DataCod = new Label();
            lbl_Ativo = new Label();
            SuspendLayout();
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(49, 50);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(18, 15);
            lbl_ID.TabIndex = 0;
            lbl_ID.Text = "ID";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(111, 46);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(36, 15);
            lbl_Email.TabIndex = 1;
            lbl_Email.Text = "E&mail";
            // 
            // lbl_CPF
            // 
            lbl_CPF.AutoSize = true;
            lbl_CPF.Location = new Point(193, 48);
            lbl_CPF.Name = "lbl_CPF";
            lbl_CPF.Size = new Size(28, 15);
            lbl_CPF.TabIndex = 2;
            lbl_CPF.Text = "CPF";
            // 
            // button1
            // 
            button1.Location = new Point(198, 226);
            button1.Name = "button1";
            button1.Size = new Size(71, 40);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Location = new Point(277, 39);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(40, 15);
            lbl_Nome.TabIndex = 4;
            lbl_Nome.Text = "Nome";
            // 
            // lbl_DataNasc
            // 
            lbl_DataNasc.AutoSize = true;
            lbl_DataNasc.Location = new Point(361, 58);
            lbl_DataNasc.Name = "lbl_DataNasc";
            lbl_DataNasc.Size = new Size(112, 15);
            lbl_DataNasc.TabIndex = 5;
            lbl_DataNasc.Text = "Data de nascimento";
            // 
            // lbl_DataCod
            // 
            lbl_DataCod.AutoSize = true;
            lbl_DataCod.Location = new Point(434, 94);
            lbl_DataCod.Name = "lbl_DataCod";
            lbl_DataCod.Size = new Size(98, 15);
            lbl_DataCod.TabIndex = 6;
            lbl_DataCod.Text = "Data De Cadastro";
            // 
            // lbl_Ativo
            // 
            lbl_Ativo.AutoSize = true;
            lbl_Ativo.Location = new Point(526, 125);
            lbl_Ativo.Name = "lbl_Ativo";
            lbl_Ativo.Size = new Size(35, 15);
            lbl_Ativo.TabIndex = 7;
            lbl_Ativo.Text = "Ativo";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Ativo);
            Controls.Add(lbl_DataCod);
            Controls.Add(lbl_DataNasc);
            Controls.Add(lbl_Nome);
            Controls.Add(button1);
            Controls.Add(lbl_CPF);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_ID);
            Name = "FrmCliente";
            Text = "FrmCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ID;
        private Label lbl_Email;
        private Label lbl_CPF;
        private Button button1;
        private Label lbl_Nome;
        private Label lbl_DataNasc;
        private Label lbl_DataCod;
        private Label lbl_Ativo;
    }
}