using MySql.Data.MySqlClient;
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
            MySqlConnection conexao = ConexaoDB.Criarconexao();

            //Abrindo conexão
            conexao.Open();

            //criando o comando SQL para inserir o usuario
            string sql = $"INSERT INTO tbUsuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha)";

            //criando o comando
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", txtbox_nome.Text);
            comando.Parameters.AddWithValue("@usuario", txtbox_usuario.Text);
            comando.Parameters.AddWithValue("@telefone", txtbox_telefone.Text);
            comando.Parameters.AddWithValue("@senha", txtbox_senha.Text);

            //executando a instrução SQL no banco 
            comando.ExecuteNonQuery();

            //fechando a conexão com o banco 
            conexao.Close();

            MessageBox.Show("Cadastro efetuado com sucesso! Você já pode realizar o loguin!");

            this.Close();
        }
    }
}
