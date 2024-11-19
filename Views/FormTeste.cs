using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenda.VariableGlobal;

namespace ProjetoAgenda.Views
{
    public partial class FormTeste : Form
    {
        public FormTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao("babalu", "1234567");
                conexao.Open();
                MessageBox.Show("Conexao deu certo1");
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao conectar! {erro.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserSession.usuario = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserSession.usuario);
        }
    }
}
