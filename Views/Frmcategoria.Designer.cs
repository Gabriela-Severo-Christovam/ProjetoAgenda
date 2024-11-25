namespace ProjetoAgenda.Views
{
    partial class Frmcategoria
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
            btn_cadastrar = new Button();
            txtbox_categoria = new TextBox();
            dgvCategoria = new DataGridView();
            btn_excluir = new Button();
            btn_alterar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_alterar);
            groupBox1.Controls.Add(btn_excluir);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btn_cadastrar);
            groupBox1.Controls.Add(txtbox_categoria);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(44, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 266);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira nova categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 31);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 4;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(7, 93);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(257, 47);
            btn_cadastrar.TabIndex = 1;
            btn_cadastrar.Text = "&Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // txtbox_categoria
            // 
            txtbox_categoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_categoria.Location = new Point(7, 45);
            txtbox_categoria.Name = "txtbox_categoria";
            txtbox_categoria.Size = new Size(257, 33);
            txtbox_categoria.TabIndex = 0;
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(331, 8);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersWidth = 62;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(517, 339);
            dgvCategoria.TabIndex = 1;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(8, 153);
            btn_excluir.Margin = new Padding(2);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(256, 46);
            btn_excluir.TabIndex = 2;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new Point(8, 211);
            btn_alterar.Margin = new Padding(2);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(256, 46);
            btn_alterar.TabIndex = 5;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // Frmcategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(860, 359);
            Controls.Add(dgvCategoria);
            Controls.Add(groupBox1);
            Name = "Frmcategoria";
            Text = "Frmcategoria";
            Load += Frmcategoria_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_cadastrar;
        private TextBox txtbox_categoria;
        private DataGridView dgvCategoria;
        private Button btn_excluir;
        private Label label2;
        private Button btn_alterar;
    }
}