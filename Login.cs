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
    public partial class Login : Form
    {
        FormHome Origem;
        public Login(FormHome origem)
        {
            InitializeComponent();
            this.Origem = origem;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(tbxNome.Text ==  "adm" && tbxSenha.Text == "adm")
            {
                Origem.lblBemVindo.Text = "Bem vindo ADM!";
                Origem.btnAdicionar.Enabled = true;
                Origem.btnRemover.Enabled = true;
                Origem.btnEditar.Enabled = true;
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Você não é o ADM!!", "Falha detectada", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }
    }
}
