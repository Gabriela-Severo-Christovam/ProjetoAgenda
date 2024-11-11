using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
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
                MySqlConnection conexao = ConexaoDB.CriarConexao();

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
    }
}
