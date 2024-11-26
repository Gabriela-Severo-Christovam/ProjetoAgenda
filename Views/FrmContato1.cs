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
    public partial class FrmContato1 : Form
    {
        public FrmContato1()
        {
            InitializeComponent();
        }

        private void AtualizarDataGrid()
        {
            ContatoController controleContato = new ContatoController();
            DataTable tabela = controleContato.Getcontato();
            dgv_contatos.DataSource = tabela;
        }


        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //Pegando os dados do formulario
            string contato = txtbox_contato.Text;
            string telefone = txtbox_telefone.Text;
            string categoria = cmb_categoria.Text;


            //Instanciando o objeto UsuarioController
            ContatoController controlecontato = new ContatoController();

            //Inserindo o usuario
            bool resultado = controlecontato.AddContato(contato, telefone, categoria);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar o usuário");
            }

            DataTable tabela = controlecontato.Getcontato();
            dgv_contatos.DataSource = tabela;

            AtualizarDataGrid();

        }

        private void FrmContato1_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
            CategoriaController controlecategoria = new CategoriaController();
            DataTable tabela = controlecategoria.GetCategorias();
            cmb_categoria.DataSource = tabela;
            cmb_categoria.DisplayMember = "categoria";

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

            string telefone = Convert.ToString(dgv_contatos.SelectedRows[0].Cells[1].Value);
            ContatoController contato = new ContatoController();
            bool resultado = contato.ExcluirContato(telefone);
            AtualizarDataGrid();
        }


//CONTINUAR...
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            int alterarcontato= Convert.ToInt32(dgv_contatos.SelectedRows[0].Cells[0].Value);
            ContatoController contato = new ContatoController();

            string usuarioContato = txtbox_contato.Text;
            string usuarioTelefone = txtbox_telefone.Text;
            string usuarioCategoria = cmb_categoria.Text;

            bool resultado = contato.Alterar(usuarioContato, usuarioTelefone ,usuarioCategoria);

            AtualizarDataGrid();
        }
    }
}
