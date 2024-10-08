namespace ProjetoAgenda
{
    public partial class frm_entrar : Form
    {
        public frm_entrar()
        {
            InitializeComponent();
        }

        private void validacao_loguin()
        {
            // Se o texto so usuario for diferente de vazio e a  quantidade de caracteres na
            // senha for maior ou igual a 8 abilita o botão de loguin. 
            if (txtbox_usuario.Text != "" && txtbox_senha.Text.Length >= 8)
            {
                btn_entrar.Enabled = true;
            } 
            else
            {
                btn_entrar.Enabled = false;
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            frm_cadastrocliente cadastro = new frm_cadastrocliente();
            cadastro.ShowDialog();
        }

        private void txtbox_usuario_TextChanged(object sender, EventArgs e)
        {
            validacao_loguin();
        }

        private void txtbox_senha_TextChanged(object sender, EventArgs e)
        {
            validacao_loguin();
        }
    }
}
