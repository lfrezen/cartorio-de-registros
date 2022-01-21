using System;
using System.ComponentModel.DataAnnotations;

namespace CartorioFacil.App.Entities
{
    public class Obito : Registro
    {
        public Obito () {}
        public Obito(
            DateTime dataObito, 
            string nomeDoFalecido, 
            DateTime dataNascimento, 
            string nomeDoPai, 
            string nomeDaMae, 
            DateTime dataNascimentoDoPai, 
            DateTime dataNascimentoDaMae)
        {
            DataObito = dataObito;
            NomeDoFalecido = nomeDoFalecido;
            DataNascimento = dataNascimento;
            NomeDoPai = nomeDoPai;
            NomeDaMae = nomeDaMae;
            DataNascimentoDoPai = dataNascimentoDoPai;
            DataNascimentoDaMae = dataNascimentoDaMae;
        }

        [Required]
        public DateTime DataObito { get; set; }

        [Required]
        public string NomeDoFalecido { get; set; }

        public DateTime DataNascimento { get; set; }

        public string NomeDoPai { get; set; }

        public string NomeDaMae { get; set; }

        public DateTime DataNascimentoDoPai { get; set; }

        public DateTime DataNascimentoDaMae { get; set; }
    }
}
