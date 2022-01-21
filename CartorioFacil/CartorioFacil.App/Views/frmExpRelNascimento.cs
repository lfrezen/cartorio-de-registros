using CartorioFacil.App.DataAccess;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CartorioFacil.App.Views
{
    public partial class frmExpRelNascimento : Form
    {
        public frmExpRelNascimento()
        {
            InitializeComponent();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Text files|*.txt" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new ApplicationDbContext())
                    {

                        var script =
                            $@"SELECT ""Id"", 
                                     ""DataNascimento"", 
                                     ""NomeDoRegistrado"", 
                                     ""NomeDoPai"", 
                                     ""NomeDaMae"", 
                                     ""DataNascimentoDoPai"", 
                                     ""DataNascimentoDaMae"", 
                                     ""CpfDoPai"", 
                                     ""CpfDaMae"", 
                                     ""DataRegistro"" 
                                FROM public.""Nascimento"" 
                               WHERE TO_CHAR(""DataNascimento"" :: DATE, 'dd/mm/yyyy') >= '{dtpInicio.Value.ToShortDateString()}'
                                 AND TO_CHAR(""DataNascimento"" :: DATE, 'dd/mm/yyyy') <= '{dtpFim.Value.ToShortDateString()}'";

                        var nascimentos = db.Nascimentos.SqlQuery(script).ToList();

                        if (nascimentos.Count < 1)
                        {
                            MessageBox.Show("Não há dados a serem exportados para o período selecionado.", "Sem dados",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            StreamWriter writer = File.AppendText(saveFileDialog.FileName);

                            foreach (var nascimento in nascimentos)
                            {
                                StringBuilder sb = new StringBuilder();

                                sb.AppendLine(
                                    $@"Registro Nº: {nascimento.Id} - Dt Nasc: {nascimento.DataNascimento.ToShortDateString()} - Nome: {nascimento.NomeDoRegistrado}");
                                sb.AppendLine(
                                    $"Nome do Pai: {nascimento.NomeDoPai} - Data Nasc: {nascimento.DataNascimentoDoPai} - CPF: {nascimento.CpfDoPai}");
                                sb.AppendLine(
                                    $"Nome da Mãe: {nascimento.NomeDaMae} - Data Nasc: {nascimento.DataNascimentoDaMae} - CPF: {nascimento.CpfDaMae}");
                                writer.WriteLine(sb);
                            }
                            writer.Close();
                            MessageBox.Show("Arquivo gerado com sucesso!", "Arquivo gerado", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
