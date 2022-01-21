using System;
using System.Linq;
using System.Windows.Forms;
using CartorioFacil.App.DataAccess;
using CartorioFacil.App.Entities;

namespace CartorioFacil.App.Views
{
    public partial class frmNascimento : Form
    {
        public frmNascimento()
        {
            InitializeComponent();
        }

        public frmNascimento(Nascimento nascimento)
        {
            InitializeComponent();

            lblId.Text = nascimento.Id.ToString();
            dtpDtRegistro.Value = nascimento.DataRegistro;
            dtpDtNascRegistrado.Value = nascimento.DataNascimento;
            txtNomeRegistrado.Text = nascimento.NomeDoRegistrado;
            txtNomePai.Text = nascimento.NomeDoPai;
            dtpDtNascPai.Value = nascimento.DataNascimentoDoPai;
            txtCpfPai.Text = nascimento.CpfDoPai;
            txtNomeMae.Text = nascimento.NomeDaMae;
            dtpDtNascMae.Value = nascimento.DataNascimentoDaMae;
            txtCpfMae.Text = nascimento.CpfDaMae;
        }

        private void ctnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        Nascimento nascimentoAtualizar = 
                            db.Nascimentos.FirstOrDefault(n => n.Id == id);
                        
                        if (nascimentoAtualizar != null){
                            nascimentoAtualizar.DataNascimento = dtpDtNascRegistrado.Value;
                            nascimentoAtualizar.NomeDoRegistrado = txtNomeRegistrado.Text;
                            nascimentoAtualizar.NomeDoPai = txtNomePai.Text;
                            nascimentoAtualizar.DataNascimentoDoPai = dtpDtNascPai.Value;
                            nascimentoAtualizar.CpfDoPai = txtCpfPai.Text;
                            nascimentoAtualizar.NomeDaMae = txtNomeMae.Text;
                            nascimentoAtualizar.DataNascimentoDaMae = dtpDtNascMae.Value;
                            nascimentoAtualizar.CpfDaMae = txtCpfMae.Text;

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
                        Nascimento nascimentoNovo = new Nascimento 
                        {
                            DataNascimento = dtpDtNascRegistrado.Value,
                            NomeDoRegistrado = txtNomeRegistrado.Text,
                            NomeDoPai = txtNomePai.Text,
                            DataNascimentoDoPai = dtpDtNascPai.Value,
                            CpfDoPai = txtCpfPai.Text,
                            NomeDaMae = txtNomeMae.Text,
                            DataNascimentoDaMae = dtpDtNascMae.Value,
                            CpfDaMae = txtCpfMae.Text
                        };

                        try
                        {
                            db.Nascimentos.Add(nascimentoNovo);
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
    }
}
