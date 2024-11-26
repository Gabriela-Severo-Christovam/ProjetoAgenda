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
    internal class CategoriaController
    {
        public bool AddCategoria(string categoria)
        {
            try
            {
                // Cria conexão, estou ultilizando a classe ConexãoDB que está dentro da pasta DATA 
                MySqlConnection conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                // Comando SQL que será executado
                string sql = "INSERT INTO tbCategorias (categoria) VALUES (@categoria);";

                // Abri a conexão com o banco 
                conexao.Open();

                // Esse cara é o responsavel por executar o comando SQL 
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Estou trocando o valor dos @ pelas informações que serão cadastradas
                // Essas informações vieram dos parametros da função
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

        public bool AlterarCategoria(string categoria, int cod_categoria)
        {
            try
            {
                // Cria conexão, estou ultilizando a classe ConexãoDB que está dentro da pasta DATA 
                MySqlConnection conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                // Comando SQL que será executado
                string sql = "UPDATE tbCategorias\r\nSET categoria = @categoria\r\nWHERE cod_categoria = @cod_categoria;";

                // Abri a conexão com o banco 
                conexao.Open();

                // Esse cara é o responsavel por executar o comando SQL 
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Estou trocando o valor dos @ pelas informações que serão cadastradas
                // Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@categoria", categoria);
                comando.Parameters.AddWithValue("@cod_categoria", cod_categoria);


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
    
        

        public DataTable GetCategorias()
        {
            //Criando uma conxão vazia
            MySqlConnection conexao = null;

            try
            {
                //inserindo a conexão usando a ConexaoDB que eu ja avia criado 
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //Montei o SELECT que retorna todas as categorias 
                string sql = "select cod_categoria AS 'Código', categoria AS 'Categoria' from tbCategorias;"+
                              $"WHERE usuario = User();";

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
                MessageBox.Show($"Erro ao recuperar categoria:{erro.Message}");
                return new DataTable();
            }
            finally
            {
                //Fechei a conexão 
                conexao.Close();
            }

        }

        public bool ExcluirCategoria(int cod_categoria)
        {
            try
            {
                // Cria conexão, estou ultilizando a classe ConexãoDB que está dentro da pasta DATA 
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                // Comando SQL que será executado
                string sql = "DELETE FROM tbCategorias WHERE cod_categoria = @cod_categoria;";

                // Abri a conexão com o banco 
                conexao.Open();

                // Esse cara é o responsavel por executar o comando SQL 
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Estou trocando o valor dos @ pelas informações que serão cadastradas
                // Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@cod_categoria", cod_categoria);

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
                MessageBox.Show($"Erro ao recuperar categoria:{erro.Message}");
                return false;
            }

        }

    }
}
