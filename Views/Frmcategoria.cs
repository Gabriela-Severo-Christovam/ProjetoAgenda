using ProjetoAgenda.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Views
{
    public partial class Frmcategoria : Form
    {
        public Frmcategoria()
        {
            InitializeComponent();
        }

        private void AtualizarDataGrid()
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategoria.DataSource = tabela;
        }


        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //Pegando os dados do formulario
            string categoria = txtbox_categoria.Text;


            //Instanciando o objeto UsuarioController
            CategoriaController controleCategoria = new CategoriaController();

            //Inserindo o usuario
            bool resultado = controleCategoria.AddCategoria(categoria);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar o usuário");
            }

            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategoria.DataSource = tabela;
        }


        private void Frmcategoria_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value);
            CategoriaController categoria = new CategoriaController();
            bool resultado = categoria.ExcluirCategoria(codigo);
            AtualizarDataGrid();
        }
    }
}
