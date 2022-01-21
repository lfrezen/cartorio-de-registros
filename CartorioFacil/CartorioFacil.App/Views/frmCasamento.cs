using CartorioFacil.App.Entities;
using System;
using System.Linq;
using System.Windows.Forms;
using CartorioFacil.App.DataAccess;

namespace CartorioFacil.App.Views
{
    public partial class frmCasamento : Form
    {
        public frmCasamento()
        {
            InitializeComponent();
        }

        public frmCasamento(Casamento casamento)
        {
            InitializeComponent();

            lblId.Text = casamento.Id.ToString();
            dtpDtRegistro.Value = casamento.DataRegistro;
            dtpDtCasamento.Value = casamento.DataCasamento;
            txtNomeConj1.Text = casamento.NomeCompletoPrimeiroConjuge;
            dtpDtNascConj1.Value = casamento.DataNascimentoPrimeiroConjuge;
            txtCpfConj1.Text = casamento.CpfPrimeiroConjuge;
            txtNomePaiConj1.Text = casamento.NomePaiPrimeiroConjuge;
            dtpDtNascPaiConj1.Value = casamento.DataNascimentoPaiPrimeiroConjuge;
            txtCpfPaiConj1.Text = casamento.CpfPaiPrimeiroConjuge;
            txtNomeMaeConj1.Text = casamento.NomeMaePrimeiroConjuge;
            dtpDtNascMaeConj1.Value = casamento.DataNascimentoMaePrimeiroConjuge;
            txtCpfMaeConj1.Text = casamento.CpfMaePrimeiroConjuge;
            txtNomeConj2.Text = casamento.NomeCompletoSegundoConjuge;
            dtpDtNascConj2.Value = casamento.DataNascimentoSegundoConjuge;
            txtCpfConj2.Text = casamento.CpfSegundoConjuge;
            txtNomePaiConj2.Text = casamento.NomePaiSegundoConjuge;
            dtpDtNascPaiConj2.Value = casamento.DataNascimentoPaiSegundoConjuge;
            txtCpfPaiConj2.Text = casamento.CpfPaiSegundoConjuge;
            txtNomeMaeConj2.Text = casamento.NomeMaeSegundoConjuge;
            dtpDtNascMaeConj2.Value = casamento.DataNascimentoMaeSegundoConjuge;
            txtCpfMaeConj2.Text = casamento.CpfMaeSegundoConjuge;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                try
                {
                    if (int.Parse(lblId.Text) > 0)
                    {
                        var id = int.Parse(lblId.Text);
                        Casamento casamentoAtualizar = db.Casamentos.FirstOrDefault(c => c.Id == id);
                        if (casamentoAtualizar != null)
                        {
                            casamentoAtualizar.DataCasamento = dtpDtCasamento.Value;
                            casamentoAtualizar.NomeCompletoPrimeiroConjuge = txtNomeConj1.Text;
                            casamentoAtualizar.DataNascimentoPrimeiroConjuge = dtpDtNascConj1.Value;
                            casamentoAtualizar.CpfPrimeiroConjuge = txtCpfConj1.Text;
                            casamentoAtualizar.NomePaiPrimeiroConjuge = txtNomePaiConj1.Text;
                            casamentoAtualizar.DataNascimentoPaiPrimeiroConjuge = dtpDtNascPaiConj1.Value;
                            casamentoAtualizar.CpfPaiPrimeiroConjuge = txtCpfPaiConj1.Text;
                            casamentoAtualizar.NomeMaePrimeiroConjuge = txtNomeMaeConj1.Text;
                            casamentoAtualizar.DataNascimentoMaePrimeiroConjuge = dtpDtNascMaeConj1.Value;
                            casamentoAtualizar.CpfMaePrimeiroConjuge = txtCpfMaeConj1.Text;
                            casamentoAtualizar.NomeCompletoSegundoConjuge = txtNomeConj2.Text;
                            casamentoAtualizar.DataNascimentoSegundoConjuge = dtpDtNascConj2.Value;
                            casamentoAtualizar.CpfSegundoConjuge = txtCpfConj2.Text;
                            casamentoAtualizar.NomePaiSegundoConjuge = txtNomePaiConj2.Text;
                            casamentoAtualizar.DataNascimentoPaiSegundoConjuge = dtpDtNascPaiConj2.Value;
                            casamentoAtualizar.CpfPaiSegundoConjuge = txtCpfPaiConj2.Text;
                            casamentoAtualizar.NomeMaeSegundoConjuge = txtNomeMaeConj2.Text;
                            casamentoAtualizar.DataNascimentoMaeSegundoConjuge = dtpDtNascMaeConj2.Value;
                            casamentoAtualizar.CpfMaeSegundoConjuge = txtCpfMaeConj2.Text;

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
                        Casamento casamentoNovo = new Casamento 
                        {
                            DataCasamento = dtpDtCasamento.Value,
                            NomeCompletoPrimeiroConjuge = txtNomeConj1.Text,
                            DataNascimentoPrimeiroConjuge = dtpDtNascConj1.Value,
                            CpfPrimeiroConjuge = txtCpfConj1.Text,
                            NomePaiPrimeiroConjuge = txtNomePaiConj1.Text,
                            DataNascimentoPaiPrimeiroConjuge = dtpDtNascPaiConj1.Value,
                            CpfPaiPrimeiroConjuge = txtCpfPaiConj1.Text,
                            NomeMaePrimeiroConjuge = txtNomeMaeConj1.Text,
                            DataNascimentoMaePrimeiroConjuge = dtpDtNascMaeConj1.Value,
                            CpfMaePrimeiroConjuge = txtCpfMaeConj1.Text,
                            NomeCompletoSegundoConjuge = txtNomeConj2.Text,
                            DataNascimentoSegundoConjuge = dtpDtNascConj2.Value,
                            CpfSegundoConjuge = txtCpfConj2.Text,
                            NomePaiSegundoConjuge = txtNomePaiConj2.Text,
                            DataNascimentoPaiSegundoConjuge = dtpDtNascPaiConj2.Value,
                            CpfPaiSegundoConjuge = txtCpfPaiConj2.Text,
                            NomeMaeSegundoConjuge = txtNomeMaeConj2.Text,
                            DataNascimentoMaeSegundoConjuge = dtpDtNascMaeConj2.Value,
                            CpfMaeSegundoConjuge = txtCpfMaeConj2.Text
                        };

                        try
                        {
                            db.Casamentos.Add(casamentoNovo);
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
                    MessageBox.Show($"Erro ao salvar os dados: {exception}", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
