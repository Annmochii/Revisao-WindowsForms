using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisao_Forms
{
    public partial class FormHome : Form
    {
        public List<Usuario> ListaUsuarios;
        public Usuario Selecionado;

        public FormHome()
        {
            InitializeComponent();
            ListaUsuarios = new List<Usuario>();
            dgvUsuarios.DataSource = ListaUsuarios;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarUsuario adicionar = new AdicionarUsuario(this, null);
            adicionar.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AdicionarUsuario adicionar = new AdicionarUsuario(this, Selecionado);
            adicionar.Show();
        }

        private void dgvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = e.RowIndex;
            Selecionado = ListaUsuarios[i];
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            ListaUsuarios.Remove(Selecionado);

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = ListaUsuarios;
            dgvUsuarios.Refresh();
        }
    }
}
