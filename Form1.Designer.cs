namespace ProjetoAgenda
{
    partial class frm_entrar
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
            lbl_usuario = new Label();
            lbl_senha = new Label();
            txtbox_usuario = new TextBox();
            txtbox_senha = new TextBox();
            btn_cadastrar = new Button();
            btn_entrar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_usuario.Location = new Point(49, 37);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(84, 28);
            lbl_usuario.TabIndex = 0;
            lbl_usuario.Text = "Usuário";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_senha.Location = new Point(49, 143);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(69, 28);
            lbl_senha.TabIndex = 1;
            lbl_senha.Text = "Senha";
            // 
            // txtbox_usuario
            // 
            txtbox_usuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_usuario.Location = new Point(49, 70);
            txtbox_usuario.Name = "txtbox_usuario";
            txtbox_usuario.Size = new Size(346, 38);
            txtbox_usuario.TabIndex = 2;
            txtbox_usuario.TextChanged += txtbox_usuario_TextChanged;
            // 
            // txtbox_senha
            // 
            txtbox_senha.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_senha.Location = new Point(49, 174);
            txtbox_senha.Name = "txtbox_senha";
            txtbox_senha.Size = new Size(346, 38);
            txtbox_senha.TabIndex = 3;
            txtbox_senha.TextChanged += txtbox_senha_TextChanged;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(243, 287);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(152, 59);
            btn_cadastrar.TabIndex = 4;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_entrar
            // 
            btn_entrar.Enabled = false;
            btn_entrar.Location = new Point(49, 287);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(152, 59);
            btn_entrar.TabIndex = 5;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cadastro;
            pictureBox1.Location = new Point(422, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(363, 406);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frm_entrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(797, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btn_entrar);
            Controls.Add(btn_cadastrar);
            Controls.Add(txtbox_senha);
            Controls.Add(txtbox_usuario);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_usuario);
            Name = "frm_entrar";
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_usuario;
        private Label lbl_senha;
        private TextBox txtbox_usuario;
        private TextBox txtbox_senha;
        private Button btn_cadastrar;
        private Button btn_entrar;
        private PictureBox pictureBox1;
    }
}
