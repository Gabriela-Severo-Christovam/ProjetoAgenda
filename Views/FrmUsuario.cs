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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void AtualizarDataGrid()
        {
            UsuarioController controleCategoria = new UsuarioController();
            DataTable tabela = controleCategoria.GetUsuario();
            DgvUsuario.DataSource = tabela;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(DgvUsuario.SelectedRows[0].Cells[1].Value);
            UsuarioController categoria = new UsuarioController();
            bool resultado = categoria.ExcluirUsuario(nome);
            AtualizarDataGrid();
        }

        private void btn_cadastrarnovasenha_Click(object sender, EventArgs e)
        {
            //Pegando os dados do formulario
            string senha = txtbox_mudarsenha.Text;

            string usuario = txtbox_usuario.Text;

            //Instanciando o objeto UsuarioController
            UsuarioController controleusuario = new UsuarioController();

            //Inserindo o usuario
            bool resultado = controleusuario.AlterarSenha(senha, usuario);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar o usuário");
            }
        }
    }
}
