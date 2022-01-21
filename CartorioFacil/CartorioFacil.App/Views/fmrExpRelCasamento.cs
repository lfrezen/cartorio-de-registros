using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using CartorioFacil.App.DataAccess;

namespace CartorioFacil.App.Views
{
    public partial class fmrExpRelCasamento : Form
    {
        public fmrExpRelCasamento()
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
                                $@"SELECT   ""Id"", 
                                            ""DataCasamento"", 
                                            ""DataNascimentoPrimeiroConjuge"", 
                                            ""NomeCompletoPrimeiroConjuge"", 
                                            ""CpfPrimeiroConjuge"", 
                                            ""NomePaiPrimeiroConjuge"", 
                                            ""NomeMaePrimeiroConjuge"", 
                                            ""DataNascimentoPaiPrimeiroConjuge"", 
                                            ""DataNascimentoMaePrimeiroConjuge"", 
                                            ""CpfPaiPrimeiroConjuge"", 
                                            ""CpfMaePrimeiroConjuge"", 
                                            ""DataNascimentoSegundoConjuge"", 
                                            ""NomeCompletoSegundoConjuge"", 
                                            ""CpfSegundoConjuge"", 
                                            ""NomePaiSegundoConjuge"", 
                                            ""NomeMaeSegundoConjuge"", 
                                            ""DataNascimentoPaiSegundoConjuge"", 
                                            ""DataNascimentoMaeSegundoConjuge"", 
                                            ""CpfPaiSegundoConjuge"", 
                                            ""CpfMaeSegundoConjuge"", 
                                            ""DataRegistro"" 
                                FROM public.""Casamento"" 
                               WHERE TO_CHAR(""DataCasamento"" :: DATE, 'dd/mm/yyyy') >= '{dtpInicio.Value.ToShortDateString()}' 
                                 AND TO_CHAR(""DataCasamento"" :: DATE, 'dd/mm/yyyy') <= '{dtpFim.Value.ToShortDateString()}'";

                        var casamentos = db.Casamentos.SqlQuery(script).ToList();

                        if (casamentos.Count < 1)
                        {
                            MessageBox.Show("Não há dados a serem exportados para o período selecionado.", "Sem dados",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            StreamWriter writer = File.AppendText(saveFileDialog.FileName);

                            foreach (var casamento in casamentos)
                            {
                                StringBuilder sb = new StringBuilder();

                                sb.AppendLine(
                                    $@"Registro Nº: {casamento.Id} - Dt Casamento: {casamento.DataCasamento.ToShortDateString()}");
                                sb.AppendLine(
                                    $"-- Dados do Cônjuge 1 --");
                                sb.AppendLine(
                                    $"Nome: {casamento.NomeCompletoPrimeiroConjuge} - Data Nasc: {casamento.DataNascimentoPrimeiroConjuge} - CPF: {casamento.CpfPrimeiroConjuge}");
                                sb.AppendLine(
                                    $"Nome do Pai: {casamento.NomePaiPrimeiroConjuge} - Data Nasc: {casamento.DataNascimentoPaiPrimeiroConjuge} - CPF: {casamento.CpfPaiPrimeiroConjuge}");
                                sb.AppendLine(
                                    $"Nome da Mãe: {casamento.NomeMaePrimeiroConjuge} - Data Nasc: {casamento.DataNascimentoMaePrimeiroConjuge} - CPF: {casamento.CpfMaePrimeiroConjuge}");
                                sb.AppendLine(
                                    $"-- Dados do Cônjuge 2 --");
                                sb.AppendLine(
                                    $"Nome do Cônjuge 2: {casamento.NomeCompletoSegundoConjuge} - Data Nasc: {casamento.DataNascimentoSegundoConjuge} - CPF: {casamento.CpfSegundoConjuge}");
                                sb.AppendLine(
                                    $"Nome do Pai: {casamento.NomePaiSegundoConjuge} - Data Nasc: {casamento.DataNascimentoPaiSegundoConjuge} - CPF: {casamento.CpfPaiSegundoConjuge}");
                                sb.AppendLine(
                                    $"Nome da Mãe: {casamento.NomeMaeSegundoConjuge} - Data Nasc: {casamento.DataNascimentoMaeSegundoConjuge} - CPF: {casamento.CpfMaeSegundoConjuge}");
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
