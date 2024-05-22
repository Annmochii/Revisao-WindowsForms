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
    public partial class FormHome : Form
    {
        public List<Contato> listaContatos;
        public Contato selecionado;

        public FormHome()
        {
            InitializeComponent();
            listaContatos = new List<Contato>();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2(this);
                form2.Show();
            }
            catch (CampoVazioException ex)
            {
                Console.WriteLine("ID do Contato: " + ex.ContatoId);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (selecionado == null)
            {
                MessageBox.Show("Não foi selecionado nenhum contato!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                listaContatos.Remove(selecionado);
                dgvAgendaTelefonica.DataSource = null;
                dgvAgendaTelefonica.DataSource = listaContatos;
                dgvAgendaTelefonica.Refresh();
            }
        }

        private void dgvAgendaTelefonica_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int x = e.RowIndex;
            selecionado = listaContatos[x];
        }
    }
}
