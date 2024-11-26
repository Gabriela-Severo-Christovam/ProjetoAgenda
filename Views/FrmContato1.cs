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
            string categoria = txtbox_categoria.Text;


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
        }
    }
}
