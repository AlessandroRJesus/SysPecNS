namespace SysPecNSDesk
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lbl = new Label();
            btn_Logar = new Button();
            btn_Cancelar = new Button();
            label2 = new Label();
            txt_Email = new TextBox();
            txt_Senha = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(139, 82);
            lbl.Name = "lbl";
            lbl.Size = new Size(36, 15);
            lbl.TabIndex = 0;
            lbl.Text = "&Email";
            // 
            // btn_Logar
            // 
            btn_Logar.Location = new Point(150, 240);
            btn_Logar.Name = "btn_Logar";
            btn_Logar.Size = new Size(75, 26);
            btn_Logar.TabIndex = 1;
            btn_Logar.Text = "&Entrar";
            btn_Logar.UseVisualStyleBackColor = true;
            btn_Logar.Click += btn_Logar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(248, 240);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 26);
            btn_Cancelar.TabIndex = 2;
            btn_Cancelar.Text = "&Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 160);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "&Senha";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(139, 100);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(210, 23);
            txt_Email.TabIndex = 4;
            txt_Email.Text = "paulo@gmail.com";
         
            // 
            // txt_Senha
            // 
            txt_Senha.Location = new Point(139, 178);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.Size = new Size(210, 23);
            txt_Senha.TabIndex = 5;
            txt_Senha.Text = "12345";
            txt_Senha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 22);
            label1.Name = "label1";
            label1.Size = new Size(335, 40);
            label1.TabIndex = 6;
            label1.Text = "Area Login Syspec";
            // 
            // FrmLogin
            // 
            AcceptButton = btn_Cancelar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            CancelButton = btn_Cancelar;
            ClientSize = new Size(471, 333);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(txt_Senha);
            Controls.Add(txt_Email);
            Controls.Add(label2);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Logar);
            Controls.Add(lbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private Button btn_Logar;
        private Button btn_Cancelar;
        private Label label2;
        private TextBox txt_Email;
        private TextBox txt_Senha;
        private Label label1;
    }
}