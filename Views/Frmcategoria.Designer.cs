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
            btn_cadastrar = new Button();
            txtbox_categoria = new TextBox();
            dgvCategoria = new DataGridView();
            btn_excluir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_cadastrar);
            groupBox1.Controls.Add(txtbox_categoria);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(63, 85);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(386, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira nova categoria";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(10, 125);
            btn_cadastrar.Margin = new Padding(4, 5, 4, 5);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(367, 38);
            btn_cadastrar.TabIndex = 1;
            btn_cadastrar.Text = "&Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // txtbox_categoria
            // 
            txtbox_categoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_categoria.Location = new Point(10, 57);
            txtbox_categoria.Margin = new Padding(4, 5, 4, 5);
            txtbox_categoria.Name = "txtbox_categoria";
            txtbox_categoria.Size = new Size(365, 45);
            txtbox_categoria.TabIndex = 0;
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(524, 14);
            dgvCategoria.Margin = new Padding(4, 5, 4, 5);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersWidth = 62;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(343, 290);
            dgvCategoria.TabIndex = 1;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(647, 321);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(112, 34);
            btn_excluir.TabIndex = 2;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // Frmcategoria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(907, 387);
            Controls.Add(btn_excluir);
            Controls.Add(dgvCategoria);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
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
    }
}