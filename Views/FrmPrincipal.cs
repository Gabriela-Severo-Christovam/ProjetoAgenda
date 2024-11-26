using ProjetoAgenda.VariableGlobal;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmcategoria categoriafrm = new Frmcategoria();
            categoriafrm.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario usuariofrm = new FrmUsuario();
            usuariofrm.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            string bemvindo = $"Seja bem-vindo {UserSession.usuario}";
            lbl_boasvindas.Text = bemvindo;
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContato1 contato = new FrmContato1();
            contato.ShowDialog();
        }
    }
}
