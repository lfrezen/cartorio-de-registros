using CartorioFacil.App.DataAccess;
using CartorioFacil.App.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CartorioFacil.App.Views
{
    public partial class frmObito : Form
    {
        public frmObito()
        {
            InitializeComponent();
        }

        public frmObito(Obito obito)
        {
            InitializeComponent();

            lblId.Text = obito.Id.ToString();
            dtpDtRegistro.Value = obito.DataRegistro;
            dtpDtObito.Value = obito.DataObito;
            dtpDtNascFalecido.Value = obito.DataNascimento;
            txtNomeFalecido.Text = obito.NomeDoFalecido;
            txtNomePai.Text = obito.NomeDoPai;
            dtpDtNascPai.Value = obito.DataNascimentoDoPai;
            txtNomeMae.Text = obito.NomeDaMae;
            dtpDtNascMae.Value = obito.DataNascimentoDaMae;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                try
                {
                    var sucesso = new Obito();
                    if (int.Parse(lblId.Text) > 0)
                    {
                        var id = int.Parse(lblId.Text);
                        Obito obitoAtualizar =
                            db.Obitos.FirstOrDefault(n => n.Id == id);

                        if (obitoAtualizar != null)
                        {
                            obitoAtualizar.DataObito = dtpDtObito.Value;
                            obitoAtualizar.DataNascimento = dtpDtNascFalecido.Value;
                            obitoAtualizar.NomeDoFalecido = txtNomeFalecido.Text;
                            obitoAtualizar.NomeDoPai = txtNomePai.Text;
                            obitoAtualizar.DataNascimentoDoPai = dtpDtNascPai.Value;
                            obitoAtualizar.NomeDaMae = txtNomeMae.Text;
                            obitoAtualizar.DataNascimentoDaMae = dtpDtNascMae.Value;
                            try
                            {
                                db.SaveChanges();
                                MessageBox.Show("Registro atualizado com sucesso!", "Registro atualizado", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show($"Erro ao salvar registro. {exception.Message}", "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        Obito obitoNovo = new Obito
                        {
                            DataObito = dtpDtObito.Value,
                            NomeDoFalecido = txtNomeFalecido.Text,
                            DataNascimento = dtpDtNascFalecido.Value,
                            NomeDoPai = txtNomePai.Text,
                            DataNascimentoDoPai = dtpDtNascPai.Value,
                            NomeDaMae = txtNomeMae.Text,
                            DataNascimentoDaMae = dtpDtNascMae.Value
                        };

                        try
                        {
                            sucesso = db.Obitos.Add(obitoNovo);
                            db.SaveChanges();
                            MessageBox.Show("Registro incluído com sucesso!", "Registro incluído", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show($"Erro ao incluir registro. {exception.Message}", "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
