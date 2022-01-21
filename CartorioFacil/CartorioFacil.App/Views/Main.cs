using CartorioFacil.App.DataAccess;
using CartorioFacil.App.Views;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CartorioFacil.App
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region MétodosLoad

        private void Main_Load(object sender, EventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                casamentoBindingSource.DataSource = db.Casamentos.ToList();
                nascimentoBindingSource.DataSource = db.Nascimentos.ToList();
                obitoBindingSource.DataSource = db.Obitos.ToList();
            }
        }

        private void TabCasamento_Load(object sender, EventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                casamentoBindingSource.DataSource = db.Casamentos.ToList();
            }
        }

        private void TabNascimento_Load(object sender, EventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                nascimentoBindingSource.DataSource = db.Nascimentos.ToList();
            }
        }

        private void TabObito_Load(object sender, EventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                obitoBindingSource.DataSource = db.Obitos.ToList();
            }
        }

        #endregion

        #region MenuExportar

        public void btnExportarNascimento_Click(object sender, EventArgs e)
        {
            using (var form = new frmExpRelNascimento())
            {
                form.ShowDialog();
            }
        }

        public void btnExportarCasamento_Click(object sender, EventArgs e)
        {
            using (var form = new fmrExpRelCasamento())
            {
                form.ShowDialog();
            }
        }

        #endregion

        #region MenuFerramentas

        public void ExportarCasamentoXML(Object sender, EventArgs e)
        {
            using (var form = new frmExpRelCasamentoXML())
            {
                form.ShowDialog();
            }
        }

        public void ExportarNascimentoXML(Object sender, EventArgs e)
        {
            using (var form = new frmExpRelNascimentosXML())
            {
                form.ShowDialog();
            }
        }

        public void ExportarObitoXML(Object sender, EventArgs e)
        {
            using (var form = new frmExpRelNascimentosXML())
            {
                form.ShowDialog();
            }
        }

        #endregion

        #region BtnsNovosRegistros

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            switch (tabControlPrincipal.SelectedTab.TabIndex)
            {
                case 0:
                    using (var form = new frmCasamento())
                    {
                        form.ShowDialog();
                    }
                    break;
                case 1:
                    using (var form = new frmNascimento())
                    {
                        form.ShowDialog();
                    }

                    break;
                case 2:
                    using (var form = new frmObito())
                    {
                        form.ShowDialog();
                    }
                    break;
            }
        }

        private void btnCasamento_Click(object sender, EventArgs e)
        {
            using (var form = new frmCasamento())
            {
                form.ShowDialog();
            }
        }

        private void btnNascimento_Click(object sender, EventArgs e)
        {
            using (var form = new frmNascimento())
            {
                form.ShowDialog();
            }
        }

        private void btnObito_Click(object sender, EventArgs e)
        {
            using (var form = new frmObito())
            {
                form.ShowDialog();
            }
        }

        #endregion

        #region DataGridCellContentClick

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            using (var db = new ApplicationDbContext())
            {
                var casamento = db.Casamentos.FirstOrDefault(n => n.Id == id);

                using (var form = new frmCasamento(casamento))
                {
                    form.ShowDialog();
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);

            using (var db = new ApplicationDbContext())
            {
                var nascimento = db.Nascimentos.FirstOrDefault(n => n.Id == id);

                using (var form = new frmNascimento(nascimento))
                {
                    form.ShowDialog();
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);

            using (var db = new ApplicationDbContext())
            {
                var obito = db.Obitos.FirstOrDefault(n => n.Id == id);

                using (var form = new frmObito(obito))
                {
                    form.ShowDialog();
                }
            }
        }

        #endregion

        #region AçãoSairJanela

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
