using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartorioFacil.App.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "cartorio" && txtSenha.Text == "cartorio")
                using (Form form = new Main())
                {
                    this.Hide();
                    form.ShowDialog();
                }
            else
                MessageBox.Show("Usuário ou Senha incorretos", "Acesso negado", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
        }
    }
}
