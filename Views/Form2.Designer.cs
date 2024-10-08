namespace ProjetoAgenda
{
    partial class frm_cadastrocliente
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
            lbl_nome = new Label();
            lbl_usuario = new Label();
            lbl_telefone = new Label();
            lbl_senha = new Label();
            lbl_Repitasenha = new Label();
            txtbox_nome = new TextBox();
            txtbox_usuario = new TextBox();
            txtbox_telefone = new TextBox();
            txtbox_senha = new TextBox();
            txtbox_repitasenha = new TextBox();
            btn_cadastrar2 = new Button();
            btn_cancelar2 = new Button();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome.Location = new Point(21, 9);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(79, 31);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome";
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_usuario.Location = new Point(21, 81);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(97, 31);
            lbl_usuario.TabIndex = 1;
            lbl_usuario.Text = "Usuário";
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_telefone.Location = new Point(18, 159);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(105, 31);
            lbl_telefone.TabIndex = 2;
            lbl_telefone.Text = "Telefone";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_senha.Location = new Point(19, 229);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(79, 31);
            lbl_senha.TabIndex = 3;
            lbl_senha.Text = "Senha";
            // 
            // lbl_Repitasenha
            // 
            lbl_Repitasenha.AutoSize = true;
            lbl_Repitasenha.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Repitasenha.Location = new Point(19, 301);
            lbl_Repitasenha.Name = "lbl_Repitasenha";
            lbl_Repitasenha.Size = new Size(168, 31);
            lbl_Repitasenha.TabIndex = 4;
            lbl_Repitasenha.Text = "Repita a senha";
            // 
            // txtbox_nome
            // 
            txtbox_nome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbox_nome.Location = new Point(21, 43);
            txtbox_nome.Name = "txtbox_nome";
            txtbox_nome.Size = new Size(387, 38);
            txtbox_nome.TabIndex = 5;
            txtbox_nome.TextChanged += txtbox_nome_TextChanged;
            // 
            // txtbox_usuario
            // 
            txtbox_usuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbox_usuario.Location = new Point(21, 116);
            txtbox_usuario.Name = "txtbox_usuario";
            txtbox_usuario.Size = new Size(387, 38);
            txtbox_usuario.TabIndex = 6;
            txtbox_usuario.TextChanged += txtbox_usuario_TextChanged;
            // 
            // txtbox_telefone
            // 
            txtbox_telefone.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbox_telefone.Location = new Point(21, 191);
            txtbox_telefone.Name = "txtbox_telefone";
            txtbox_telefone.Size = new Size(387, 38);
            txtbox_telefone.TabIndex = 7;
            txtbox_telefone.TextChanged += txtbox_telefone_TextChanged;
            // 
            // txtbox_senha
            // 
            txtbox_senha.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbox_senha.Location = new Point(21, 264);
            txtbox_senha.Name = "txtbox_senha";
            txtbox_senha.Size = new Size(387, 38);
            txtbox_senha.TabIndex = 8;
            txtbox_senha.TextChanged += txtbox_senha_TextChanged;
            // 
            // txtbox_repitasenha
            // 
            txtbox_repitasenha.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbox_repitasenha.Location = new Point(21, 340);
            txtbox_repitasenha.Name = "txtbox_repitasenha";
            txtbox_repitasenha.Size = new Size(387, 38);
            txtbox_repitasenha.TabIndex = 9;
            txtbox_repitasenha.TextChanged += txtbox_repitasenha_TextChanged;
            // 
            // btn_cadastrar2
            // 
            btn_cadastrar2.BackColor = Color.Transparent;
            btn_cadastrar2.Enabled = false;
            btn_cadastrar2.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cadastrar2.Location = new Point(24, 411);
            btn_cadastrar2.Name = "btn_cadastrar2";
            btn_cadastrar2.Size = new Size(163, 65);
            btn_cadastrar2.TabIndex = 10;
            btn_cadastrar2.Text = "Cadastrar";
            btn_cadastrar2.UseVisualStyleBackColor = false;
            btn_cadastrar2.Click += btn_cadastrar2_Click;
            // 
            // btn_cancelar2
            // 
            btn_cancelar2.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancelar2.Location = new Point(245, 411);
            btn_cancelar2.Name = "btn_cancelar2";
            btn_cancelar2.Size = new Size(163, 65);
            btn_cancelar2.TabIndex = 11;
            btn_cancelar2.Text = "Cancelar";
            btn_cancelar2.UseVisualStyleBackColor = true;
            // 
            // frm_cadastrocliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(432, 505);
            Controls.Add(btn_cancelar2);
            Controls.Add(btn_cadastrar2);
            Controls.Add(txtbox_repitasenha);
            Controls.Add(txtbox_senha);
            Controls.Add(txtbox_telefone);
            Controls.Add(txtbox_usuario);
            Controls.Add(txtbox_nome);
            Controls.Add(lbl_Repitasenha);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_telefone);
            Controls.Add(lbl_usuario);
            Controls.Add(lbl_nome);
            Name = "frm_cadastrocliente";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nome;
        private Label lbl_usuario;
        private Label lbl_telefone;
        private Label lbl_senha;
        private Label lbl_Repitasenha;
        private TextBox txtbox_nome;
        private TextBox txtbox_usuario;
        private TextBox txtbox_telefone;
        private TextBox txtbox_senha;
        private TextBox txtbox_repitasenha;
        private Button btn_cadastrar2;
        private Button btn_cancelar2;
    }
}