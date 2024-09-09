namespace SysPecNSDesk
{
    partial class FrmPedidoNovo
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            btn_InserirPedido = new Button();
            txt_IdCliente = new TextBox();
            txt_Cliente = new TextBox();
            txt_Usuario = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txt_Pedido = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(22, 217);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 204);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Itens do Pedido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 71);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 0;
            label4.Text = "&Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_InserirPedido);
            groupBox2.Controls.Add(txt_IdCliente);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_Cliente);
            groupBox2.Controls.Add(txt_Usuario);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(22, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 159);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Identificação";
            // 
            // btn_InserirPedido
            // 
            btn_InserirPedido.Location = new Point(294, 107);
            btn_InserirPedido.Name = "btn_InserirPedido";
            btn_InserirPedido.Size = new Size(75, 23);
            btn_InserirPedido.TabIndex = 4;
            btn_InserirPedido.Text = "&Abrir";
            btn_InserirPedido.UseVisualStyleBackColor = true;
            btn_InserirPedido.Click += btn_InserirPedido_Click;
            // 
            // txt_IdCliente
            // 
            txt_IdCliente.Location = new Point(80, 68);
            txt_IdCliente.Name = "txt_IdCliente";
            txt_IdCliente.Size = new Size(54, 23);
            txt_IdCliente.TabIndex = 3;
            // 
            // txt_Cliente
            // 
            txt_Cliente.Location = new Point(140, 68);
            txt_Cliente.Name = "txt_Cliente";
            txt_Cliente.Size = new Size(205, 23);
            txt_Cliente.TabIndex = 2;
            // 
            // txt_Usuario
            // 
            txt_Usuario.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_Usuario.Location = new Point(83, 32);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.ReadOnly = true;
            txt_Usuario.Size = new Size(205, 25);
            txt_Usuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 35);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 40);
            label1.TabIndex = 2;
            label1.Text = "NOVO PEDIDO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(620, 29);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Número";
            // 
            // txt_Pedido
            // 
            txt_Pedido.Location = new Point(677, 26);
            txt_Pedido.Name = "txt_Pedido";
            txt_Pedido.Size = new Size(100, 23);
            txt_Pedido.TabIndex = 4;
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Pedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private TextBox txt_Pedido;
        private Label label4;
        private TextBox txt_Cliente;
        private TextBox txt_Usuario;
        private Label label3;
        private Button btn_InserirPedido;
        private TextBox txt_IdCliente;
    }
}