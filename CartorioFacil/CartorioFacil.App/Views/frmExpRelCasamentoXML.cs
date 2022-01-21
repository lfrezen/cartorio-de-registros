using CartorioFacil.App.DataAccess;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CartorioFacil.App.Views
{
    public partial class frmExpRelCasamentoXML : Form
    {
        public frmExpRelCasamentoXML()
        {
            InitializeComponent();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "XML-File | *.xml" })
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
                            XmlSerializer serializer = new XmlSerializer(casamentos.GetType());

                            StreamWriter writer = File.AppendText(saveFileDialog.FileName);

                            serializer.Serialize(writer, casamentos);
                            
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
