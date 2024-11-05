using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ProjetoAgenda.controller
{
    internal class UsuarioController
    {
        // bool retorna true ou false
        public bool AddUsuario(string nome, string usuario, string telefone, string senha)
        {
            try
            {
                // Cria conexão, estou ultilizando a classe ConexãoDB que está dentro da pasta DATA 
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                // Comando SQL que será executado
                string sql = "INSERT INTO tbUsuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

                // Abri a conexão com o banco 
                conexao.Open();

                // Esse cara é o responsavel por executar o comando SQL 
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Estou trocando o valor dos @ pelas informações que serão cadastradas
                // Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@senha", senha);

                //Executando no banco de dados 
                int LinhasAfetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if (LinhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //try e catch para dar o aviso ao usuario quando o nome de usuario ja existe no banco de dados para que ele possa mudar. 
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao cadastrar: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool ValidarLoguin(string usuario, string senha)
        {
            try
            {

                // Cria conexão, estou ultilizando a classe ConexãoDB que está dentro da pasta DATA 
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                //Comando SQL que será executado
                string sql = @" SELECT* from tbUsuarios
                            WHERE usuario = @usuario 
                            AND binary senha = @senha;";

                //Abri a conexão com o banco 
                conexao.Open();

                //responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocando o valor dos @ pelas informações que serão cadastradas
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                //Executando no banco de dados
                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    conexao.Close();
                    return true;
                }
                else
                {
                    conexao.Close();
                    return false;
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao verificar o usuario.{erro.Message}");
                return false;
            }

        }
    }
}