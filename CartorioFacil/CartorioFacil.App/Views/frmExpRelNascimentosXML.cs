using CartorioFacil.App.DataAccess;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CartorioFacil.App.Views
{
    public partial class frmExpRelNascimentosXML : Form
    {
        public frmExpRelNascimentosXML()
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
                            XmlSerializer serializer = new XmlSerializer(nascimentos.GetType());

                            StreamWriter writer = File.AppendText(saveFileDialog.FileName);

                            serializer.Serialize(writer, nascimentos);
                            
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
