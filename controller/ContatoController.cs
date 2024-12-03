using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.controller
{
    internal class ContatoController
    {
        public bool AddContato(string contato, string telefone, string categoria)
        {
            try
            {
                // Cria conexão, estou ultilizando a classe ConexãoDB que está dentro da pasta DATA 
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                // Comando SQL que será executado
                string sql = "INSERT INTO tbContato (contato, telefone, categoria) VALUES (@contato, @telefone, @categoria);";

                // Abri a conexão com o banco 
                conexao.Open();

                // Esse cara é o responsavel por executar o comando SQL 
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Estou trocando o valor dos @ pelas informações que serão cadastradas
                // Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@contato", contato);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@categoria", categoria);

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

        public DataTable Getcontato()
        {
            //Criando uma conxão vazia
            MySqlConnection conexao = null;

            try
            {
                //inserindo a conexão usando a ConexaoDB que eu ja avia criado 
                conexao = ConexaoDB.CriarConexao();

                //Montei o SELECT que retorna todas as categorias 
                string sql = "select contato AS 'Contato', telefone AS 'telefone', categoria AS 'Categoria' from tbContato;";

                //Abri a conexão 
                conexao.Open();

                //Criei um adaptador 
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                //Criei uma tabela vazia 
                DataTable tabela = new DataTable();

                //Pedindo para o adaptador preencher a tabela 
                adaptador.Fill(tabela);

                //Retorno a tabela preenchida 
                return tabela;
            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar contato:{erro.Message}");
                return new DataTable();
            }
            finally
            {
                //Fechei a conexão 
                conexao.Close();
            }
        }

        public bool ExcluirContato(string telefone)
        {
            try
            {
                // Cria conexão, estou ultilizando a classe ConexãoDB que está dentro da pasta DATA 
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                // Comando SQL que será executado
                string sql = "DELETE FROM tbContato WHERE telefone = @telefone;";

                // Abri a conexão com o banco 
                conexao.Open();

                // Esse cara é o responsavel por executar o comando SQL 
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Estou trocando o valor dos @ pelas informações que serão cadastradas
                // Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@telefone", telefone);

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

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao deletar contato:{erro.Message}");
                return false;
            }
        }

        public bool Alterar(string contato, string telefone, string categoria)
        {
            try
            {
                // Cria conexão, estou ultilizando a classe ConexãoDB que está dentro da pasta DATA 
                MySqlConnection conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);


                // Comando SQL que será executado
                string sql = @"UPDATE tbContato
                              SET contato = @contato, 
                              telefone = @telefone,
                              categoria = @categoria 
                              WHERE telefone = @telefone;";

                // Abri a conexão com o banco 
                conexao.Open();

                // Esse cara é o responsavel por executar o comando SQL 
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Estou trocando o valor dos @ pelas informações que serão cadastradas
                // Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@contato", contato);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@categoria", categoria);
             
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
            //try e catch para dar o aviso ao usuario quando o nome da categoria ja existe no banco de dados para que ele possa mudar. 
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao cadastrar: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }
    }
}
