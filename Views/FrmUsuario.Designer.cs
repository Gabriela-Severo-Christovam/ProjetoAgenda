namespace ProjetoAgenda.Views
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtbox_usuario = new TextBox();
            txtbox_mudarsenha = new TextBox();
            btn_cadastrarnovasenha = new Button();
            DgvUsuario = new DataGridView();
            btn_excluir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtbox_usuario);
            groupBox1.Controls.Add(txtbox_mudarsenha);
            groupBox1.Controls.Add(btn_cadastrarnovasenha);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(298, 33);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(242, 171);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alterar senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Nova senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // txtbox_usuario
            // 
            txtbox_usuario.Location = new Point(9, 45);
            txtbox_usuario.Name = "txtbox_usuario";
            txtbox_usuario.Size = new Size(228, 29);
            txtbox_usuario.TabIndex = 2;
            // 
            // txtbox_mudarsenha
            // 
            txtbox_mudarsenha.Location = new Point(9, 96);
            txtbox_mudarsenha.Margin = new Padding(2);
            txtbox_mudarsenha.Name = "txtbox_mudarsenha";
            txtbox_mudarsenha.Size = new Size(228, 29);
            txtbox_mudarsenha.TabIndex = 1;
            // 
            // btn_cadastrarnovasenha
            // 
            btn_cadastrarnovasenha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cadastrarnovasenha.Location = new Point(45, 135);
            btn_cadastrarnovasenha.Margin = new Padding(2);
            btn_cadastrarnovasenha.Name = "btn_cadastrarnovasenha";
            btn_cadastrarnovasenha.Size = new Size(148, 25);
            btn_cadastrarnovasenha.TabIndex = 0;
            btn_cadastrarnovasenha.Text = "Cadastrar";
            btn_cadastrarnovasenha.UseVisualStyleBackColor = true;
            btn_cadastrarnovasenha.Click += btn_cadastrarnovasenha_Click;
            // 
            // DgvUsuario
            // 
            DgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvUsuario.Location = new Point(21, 33);
            DgvUsuario.Margin = new Padding(2);
            DgvUsuario.Name = "DgvUsuario";
            DgvUsuario.RowHeadersWidth = 62;
            DgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvUsuario.Size = new Size(252, 135);
            DgvUsuario.TabIndex = 1;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(98, 184);
            btn_excluir.Margin = new Padding(2);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(78, 29);
            btn_excluir.TabIndex = 2;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(560, 224);
            Controls.Add(btn_excluir);
            Controls.Add(DgvUsuario);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtbox_mudarsenha;
        private Button btn_cadastrarnovasenha;
        private DataGridView DgvUsuario;
        private Button btn_excluir;
        private Label label1;
        private TextBox txtbox_usuario;
        private Label label2;
    }
}