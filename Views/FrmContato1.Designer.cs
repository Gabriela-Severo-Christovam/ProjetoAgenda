namespace ProjetoAgenda.Views
{
    partial class FrmContato1
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
            btn_alterar = new Button();
            btn_excluir = new Button();
            btn_cadastrar = new Button();
            txtbox_categoria = new TextBox();
            txtbox_telefone = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtbox_contato = new TextBox();
            dgv_contatos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_contatos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_alterar);
            groupBox1.Controls.Add(btn_excluir);
            groupBox1.Controls.Add(btn_cadastrar);
            groupBox1.Controls.Add(txtbox_categoria);
            groupBox1.Controls.Add(txtbox_telefone);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtbox_contato);
            groupBox1.Location = new Point(94, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 409);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar Contato";
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new Point(101, 319);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(94, 39);
            btn_alterar.TabIndex = 9;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(169, 263);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(94, 39);
            btn_excluir.TabIndex = 8;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(32, 263);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(94, 39);
            btn_cadastrar.TabIndex = 7;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // txtbox_categoria
            // 
            txtbox_categoria.Location = new Point(32, 202);
            txtbox_categoria.Name = "txtbox_categoria";
            txtbox_categoria.Size = new Size(231, 27);
            txtbox_categoria.TabIndex = 6;
            // 
            // txtbox_telefone
            // 
            txtbox_telefone.Location = new Point(32, 134);
            txtbox_telefone.Name = "txtbox_telefone";
            txtbox_telefone.Size = new Size(231, 27);
            txtbox_telefone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 171);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 4;
            label3.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 106);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Telefone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 38);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "Contato";
            // 
            // txtbox_contato
            // 
            txtbox_contato.Location = new Point(32, 69);
            txtbox_contato.Name = "txtbox_contato";
            txtbox_contato.Size = new Size(231, 27);
            txtbox_contato.TabIndex = 2;
            // 
            // dgv_contatos
            // 
            dgv_contatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_contatos.Location = new Point(441, 38);
            dgv_contatos.Name = "dgv_contatos";
            dgv_contatos.RowHeadersWidth = 51;
            dgv_contatos.Size = new Size(394, 403);
            dgv_contatos.TabIndex = 1;
            // 
            // FrmContato1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(870, 510);
            Controls.Add(dgv_contatos);
            Controls.Add(groupBox1);
            Name = "FrmContato1";
            Text = "FrmContato1";
            Load += FrmContato1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_contatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtbox_contato;
        private TextBox txtbox_categoria;
        private TextBox txtbox_telefone;
        private Label label3;
        private Label label2;
        private Button btn_alterar;
        private Button btn_excluir;
        private Button btn_cadastrar;
        private DataGridView dgv_contatos;
    }
}