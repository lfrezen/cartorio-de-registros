using System;
using System.ComponentModel.DataAnnotations;

namespace CartorioFacil.App.Entities
{
    public class Nascimento : Registro
    {
        public Nascimento()
        {

        }

        public Nascimento(
            DateTime dataNascimento, 
            string nomeDoRegistrado, 
            string nomeDoPai, 
            string nomeDaMae, 
            DateTime dataNascimentoDoPai, 
            DateTime dataNascimentoDaMae, 
            string cpfDoPai, 
            string cpfDaMae)
        {
            DataNascimento = dataNascimento;
            NomeDoRegistrado = nomeDoRegistrado;
            NomeDoPai = nomeDoPai;
            NomeDaMae = nomeDaMae;
            DataNascimentoDoPai = dataNascimentoDoPai;
            DataNascimentoDaMae = dataNascimentoDaMae;
            CpfDoPai = cpfDoPai;
            CpfDaMae = cpfDaMae;
        }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string NomeDoRegistrado { get; set; }

        public string NomeDoPai { get; set; }

        public string NomeDaMae { get; set; }

        public DateTime DataNascimentoDoPai { get; set; }

        public DateTime DataNascimentoDaMae { get; set; }

        public string CpfDoPai { get; set; }

        public string CpfDaMae { get; set; }
    }
}
