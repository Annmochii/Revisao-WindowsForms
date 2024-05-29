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
    public partial class AdicionarUsuario : Form
    {
        FormHome Origem;
        Usuario Selecionado;

        public AdicionarUsuario(FormHome origem, Usuario selecionado)
        {
            InitializeComponent();
            this.Origem = origem;
            this.Selecionado = selecionado;

            cbxTipo.Items.Add(new TipoUsuario(1, "Administrador"));
            cbxTipo.Items.Add(new TipoUsuario(2, "Comum"));
            cbxTipo.DisplayMember = "Nome";

            if (Selecionado != null)
            {
                tbxNome.Text = Selecionado.Nome;
                tbxUsuario.Text = Selecionado.NomeUsuario;
                tbxEmail.Text = Selecionado.Email;

                foreach( TipoUsuario t in cbxTipo.Items )
                {
                    if (t.Id == Selecionado.Tipo.Id && t.Nome == Selecionado.Tipo.Nome)
                    {
                        cbxTipo.SelectedItem = t;
                        break;
                    }
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int proxID = Origem.ListaUsuarios.Count + 1;

            if (tbxNome.Text == "" || tbxEmail.Text == "" || tbxSenha.Text == "" || tbxUsuario.Text == "" || (TipoUsuario)cbxTipo.SelectedItem == null)
            {
                throw new CampoVazioException(proxID, "Um dos Campos está vazio!");
            }
            if (Selecionado != null)
            {
                Selecionado.Nome = tbxNome.Text;
                Selecionado.NomeUsuario = tbxUsuario.Text;
                Selecionado.Email = tbxEmail.Text;
                Selecionado.Senha = tbxSenha.Text;
                Selecionado.Tipo = (TipoUsuario)cbxTipo.SelectedItem;

                Origem.ListaUsuarios[Selecionado.Id - 1] = Selecionado;
            }
            else
            {
                Usuario usuario = new Usuario(proxID, tbxNome.Text, tbxUsuario.Text, tbxEmail.Text, tbxSenha.Text, (TipoUsuario)cbxTipo.SelectedItem);
                Origem.ListaUsuarios.Add(usuario);
            }

            Origem.dgvUsuarios.DataSource = null;
            Origem.dgvUsuarios.DataSource = Origem.ListaUsuarios;
            Origem.dgvUsuarios.Refresh();

            this.Close();
        }
    }
}
