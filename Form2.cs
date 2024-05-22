using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoTeste
{
    public partial class Form2 : Form
    {
        FormHome Origem;

        public Form2(FormHome origem)
        {
            InitializeComponent();
            this.Origem = origem;

            cbxTipo.Items.Add(new TipoTelefone(1, "Profissional"));
            cbxTipo.Items.Add(new TipoTelefone(2, "Pessoal"));
            cbxTipo.Items.Add(new TipoTelefone(3, "Recado"));
            cbxTipo.Items.Add(new TipoTelefone(4, "Whatsapp"));
            cbxTipo.DisplayMember = "none";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int proxID = Origem.listaContatos.Count + 1;

            if (tbxNome.Text == "" || tbxSobrenome.Text == "" || tbxTelefone.Text == "" || (TipoTelefone)cbxTipo.SelectedItem == null)
            {
                throw new CampoVazioException(proxID, "Um dos campos está vazio!");
            }
            else
            {
                Contato aux = new Contato(proxID, tbxNome.Text, tbxSobrenome.Text, tbxTelefone.Text, (TipoTelefone)cbxTipo.SelectedItem);
                Origem.listaContatos.Add(aux);

                Origem.dgvAgendaTelefonica.DataSource = null;
                Origem.dgvAgendaTelefonica.DataSource = Origem.listaContatos;
                Origem.dgvAgendaTelefonica.Refresh();

                this.Close();
            }

        }
    }
}
