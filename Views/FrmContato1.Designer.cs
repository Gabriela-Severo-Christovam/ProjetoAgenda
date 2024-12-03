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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            cmb_categoria = new ComboBox();
            btn_alterar = new Button();
            btn_excluir = new Button();
            btn_cadastrar = new Button();
            txtbox_telefone = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtbox_contato = new TextBox();
            dgv_contatos = new DataGridView();
            AVISOS = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_contatos).BeginInit();
            AVISOS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmb_categoria);
            groupBox1.Controls.Add(btn_alterar);
            groupBox1.Controls.Add(btn_excluir);
            groupBox1.Controls.Add(btn_cadastrar);
            groupBox1.Controls.Add(txtbox_telefone);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtbox_contato);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(36, 21);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(257, 307);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar Contato";
            // 
            // cmb_categoria
            // 
            cmb_categoria.FormattingEnabled = true;
            cmb_categoria.Location = new Point(28, 151);
            cmb_categoria.Margin = new Padding(3, 2, 3, 2);
            cmb_categoria.Name = "cmb_categoria";
            cmb_categoria.Size = new Size(203, 23);
            cmb_categoria.TabIndex = 10;
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new Point(88, 239);
            btn_alterar.Margin = new Padding(3, 2, 3, 2);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(82, 29);
            btn_alterar.TabIndex = 9;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(148, 197);
            btn_excluir.Margin = new Padding(3, 2, 3, 2);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(82, 29);
            btn_excluir.TabIndex = 8;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(28, 197);
            btn_cadastrar.Margin = new Padding(3, 2, 3, 2);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(82, 29);
            btn_cadastrar.TabIndex = 7;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // txtbox_telefone
            // 
            txtbox_telefone.Location = new Point(28, 100);
            txtbox_telefone.Margin = new Padding(3, 2, 3, 2);
            txtbox_telefone.Name = "txtbox_telefone";
            txtbox_telefone.Size = new Size(203, 23);
            txtbox_telefone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 128);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 80);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Telefone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 28);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Contato";
            // 
            // txtbox_contato
            // 
            txtbox_contato.Location = new Point(28, 52);
            txtbox_contato.Margin = new Padding(3, 2, 3, 2);
            txtbox_contato.Name = "txtbox_contato";
            txtbox_contato.Size = new Size(203, 23);
            txtbox_contato.TabIndex = 2;
            // 
            // dgv_contatos
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgv_contatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_contatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_contatos.Location = new Point(339, 28);
            dgv_contatos.Margin = new Padding(3, 2, 3, 2);
            dgv_contatos.Name = "dgv_contatos";
            dgv_contatos.RowHeadersWidth = 51;
            dgv_contatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_contatos.Size = new Size(345, 302);
            dgv_contatos.TabIndex = 1;
            // 
            // AVISOS
            // 
            AVISOS.Controls.Add(label7);
            AVISOS.Controls.Add(label6);
            AVISOS.Controls.Add(label5);
            AVISOS.Controls.Add(label4);
            AVISOS.ForeColor = SystemColors.ActiveCaptionText;
            AVISOS.Location = new Point(36, 333);
            AVISOS.Name = "AVISOS";
            AVISOS.Size = new Size(649, 147);
            AVISOS.TabIndex = 2;
            AVISOS.TabStop = false;
            AVISOS.Text = "AVISOS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(5, 113);
            label7.Name = "label7";
            label7.Size = new Size(555, 21);
            label7.TabIndex = 3;
            label7.Text = "NÃO PRECISA COLOCAR O TELEFONE NOVAMENTE, ai clique no botão alterar ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(6, 86);
            label6.Name = "label6";
            label6.Size = new Size(515, 21);
            label6.TabIndex = 2;
            label6.Text = "na tabela(dgv) e coloque apenas  o  nome do contato e a nova categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(6, 61);
            label5.Name = "label5";
            label5.Size = new Size(559, 21);
            label5.TabIndex = 1;
            label5.Text = "Caso você queira alterar o contato de alguem apenas selecione  com um clique";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(6, 22);
            label4.Name = "label4";
            label4.Size = new Size(391, 21);
            label4.TabIndex = 0;
            label4.Text = "Para cadastrar um telefone coloque apenas 8 numeros";
            // 
            // FrmContato1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(723, 499);
            Controls.Add(AVISOS);
            Controls.Add(dgv_contatos);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmContato1";
            Text = "FrmContato1";
            Load += FrmContato1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_contatos).EndInit();
            AVISOS.ResumeLayout(false);
            AVISOS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtbox_contato;
        private TextBox txtbox_telefone;
        private Label label3;
        private Label label2;
        private Button btn_alterar;
        private Button btn_excluir;
        private Button btn_cadastrar;
        private DataGridView dgv_contatos;
        private ComboBox cmb_categoria;
        private GroupBox AVISOS;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
    }
}