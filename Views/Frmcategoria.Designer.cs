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
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_cadastrar);
            groupBox1.Controls.Add(txtbox_categoria);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(44, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira nova categoria";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(7, 75);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(257, 23);
            btn_cadastrar.TabIndex = 1;
            btn_cadastrar.Text = "&Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // txtbox_categoria
            // 
            txtbox_categoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_categoria.Location = new Point(7, 34);
            txtbox_categoria.Name = "txtbox_categoria";
            txtbox_categoria.Size = new Size(257, 33);
            txtbox_categoria.TabIndex = 0;
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(359, 30);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.Size = new Size(240, 174);
            dgvCategoria.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(257, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Frmcategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(635, 232);
            Controls.Add(button1);
            Controls.Add(dgvCategoria);
            Controls.Add(groupBox1);
            Name = "Frmcategoria";
            Text = "Frmcategoria";
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
        private Button button1;
    }
}