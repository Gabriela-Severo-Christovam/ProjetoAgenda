using MySql.Data.MySqlClient;
using ProjetoAgenda.controller;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class frm_cadastrocliente : Form
    {
        public frm_cadastrocliente()
        {
            InitializeComponent();
        }

        private void validacao_cadastro()
        {
            if (txtbox_nome.Text != "" && txtbox_usuario.Text != "" && txtbox_senha.Text.Length >= 8 && txtbox_repitasenha.Text != "" && txtbox_repitasenha.Text == txtbox_senha.Text)
            {
                btn_cadastrar2.Enabled = true;
            }
            else
            {
                btn_cadastrar2.Enabled = false;
            }
        }

        private void txtbox_nome_TextChanged(object sender, EventArgs e)
        {
            validacao_cadastro();
        }

        private void txtbox_usuario_TextChanged(object sender, EventArgs e)
        {
            validacao_cadastro();
        }

        private void txtbox_telefone_TextChanged(object sender, EventArgs e)
        {
            validacao_cadastro();
        }

        private void txtbox_senha_TextChanged(object sender, EventArgs e)
        {
            validacao_cadastro();
        }

        private void txtbox_repitasenha_TextChanged(object sender, EventArgs e)
        {
            validacao_cadastro();
        }

        private void btn_cadastrar2_Click(object sender, EventArgs e)
        {
            //Pegando os dados do formulario
            string nome = txtbox_nome.Text;
            string usuario = txtbox_usuario.Text;
            string telefone = txtbox_telefone.Text;
            string senha = txtbox_senha.Text;

            //Instanciando o objeto UsuarioController
            UsuarioController controleusuario = new UsuarioController();

            //Inserindo o usuario
            bool resultado = controleusuario.AddUsuario(nome, usuario, telefone, senha);

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
