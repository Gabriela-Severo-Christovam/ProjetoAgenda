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
            groupBox1.Controls.Add(txtbox_mudarsenha);
            groupBox1.Controls.Add(btn_cadastrarnovasenha);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(426, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 212);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alterar senha";
            // 
            // txtbox_mudarsenha
            // 
            txtbox_mudarsenha.Location = new Point(13, 59);
            txtbox_mudarsenha.Name = "txtbox_mudarsenha";
            txtbox_mudarsenha.Size = new Size(324, 39);
            txtbox_mudarsenha.TabIndex = 1;
            // 
            // btn_cadastrarnovasenha
            // 
            btn_cadastrarnovasenha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cadastrarnovasenha.Location = new Point(65, 140);
            btn_cadastrarnovasenha.Name = "btn_cadastrarnovasenha";
            btn_cadastrarnovasenha.Size = new Size(212, 42);
            btn_cadastrarnovasenha.TabIndex = 0;
            btn_cadastrarnovasenha.Text = "Cadastrar";
            btn_cadastrarnovasenha.UseVisualStyleBackColor = true;
            // 
            // DgvUsuario
            // 
            DgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvUsuario.Location = new Point(30, 55);
            DgvUsuario.Name = "DgvUsuario";
            DgvUsuario.RowHeadersWidth = 62;
            DgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvUsuario.Size = new Size(360, 225);
            DgvUsuario.TabIndex = 1;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(140, 306);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(112, 34);
            btn_excluir.TabIndex = 2;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(800, 373);
            Controls.Add(btn_excluir);
            Controls.Add(DgvUsuario);
            Controls.Add(groupBox1);
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
    }
}