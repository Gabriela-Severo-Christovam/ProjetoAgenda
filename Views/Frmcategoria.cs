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
        }
    }
}
