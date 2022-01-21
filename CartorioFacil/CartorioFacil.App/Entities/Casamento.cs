using System;
using System.ComponentModel.DataAnnotations;

namespace CartorioFacil.App.Entities
{
    public class Casamento : Registro
    {
        public Casamento () {}
        public Casamento(
            DateTime dataCasamento, 
            DateTime dataNascimentoPrimeiroConjuge, 
            string nomeCompletoPrimeiroConjuge, 
            string cpfPrimeiroConjuge, 
            string nomePaiPrimeiroConjuge, 
            string nomeMaePrimeiroConjuge, 
            DateTime dataNascimentoPaiPrimeiroConjuge, 
            DateTime dataNascimentoMaePrimeiroConjuge, 
            string cpfPaiPrimeiroConjuge, 
            string cpfMaePrimeiroConjuge, 
            DateTime dataNascimentoSegundoConjuge, 
            string nomeCompletoSegundoConjuge, 
            string cpfSegundoConjuge, 
            string nomePaiSegundoConjuge, 
            string nomeMaeSegundoConjuge, 
            DateTime dataNascimentoPaiSegundoConjuge, 
            DateTime dataNascimentoMaeSegundoConjuge, 
            string cpfPaiSegundoConjuge, 
            string cpfMaeSegundoConjuge)
        {
            DataCasamento = dataCasamento;
            DataNascimentoPrimeiroConjuge = dataNascimentoPrimeiroConjuge;
            NomeCompletoPrimeiroConjuge = nomeCompletoPrimeiroConjuge;
            CpfPrimeiroConjuge = cpfPrimeiroConjuge;
            NomePaiPrimeiroConjuge = nomePaiPrimeiroConjuge;
            NomeMaePrimeiroConjuge = nomeMaePrimeiroConjuge;
            DataNascimentoPaiPrimeiroConjuge = dataNascimentoPaiPrimeiroConjuge;
            DataNascimentoMaePrimeiroConjuge = dataNascimentoMaePrimeiroConjuge;
            CpfPaiPrimeiroConjuge = cpfPaiPrimeiroConjuge;
            CpfMaePrimeiroConjuge = cpfMaePrimeiroConjuge;
            DataNascimentoSegundoConjuge = dataNascimentoSegundoConjuge;
            NomeCompletoSegundoConjuge = nomeCompletoSegundoConjuge;
            CpfSegundoConjuge = cpfSegundoConjuge;
            NomePaiSegundoConjuge = nomePaiSegundoConjuge;
            NomeMaeSegundoConjuge = nomeMaeSegundoConjuge;
            DataNascimentoPaiSegundoConjuge = dataNascimentoPaiSegundoConjuge;
            DataNascimentoMaeSegundoConjuge = dataNascimentoMaeSegundoConjuge;
            CpfPaiSegundoConjuge = cpfPaiSegundoConjuge;
            CpfMaeSegundoConjuge = cpfMaeSegundoConjuge;
        }

        [Required]
        public DateTime DataCasamento { get; set; }

        [Required]
        public DateTime DataNascimentoPrimeiroConjuge { get; set; }

        [Required]
        public string NomeCompletoPrimeiroConjuge { get; set; }

        public string CpfPrimeiroConjuge { get; set; }

        public string NomePaiPrimeiroConjuge { get; set; }

        public string NomeMaePrimeiroConjuge { get; set; }

        public DateTime DataNascimentoPaiPrimeiroConjuge { get; set; }

        public DateTime DataNascimentoMaePrimeiroConjuge { get; set; }

        public string CpfPaiPrimeiroConjuge { get; set; }

        public string CpfMaePrimeiroConjuge { get; set; }


        [Required]
        public DateTime DataNascimentoSegundoConjuge { get; set; }

        [Required]
        public string NomeCompletoSegundoConjuge { get; set; }

        public string CpfSegundoConjuge { get; set; }

        public string NomePaiSegundoConjuge { get; set; }

        public string NomeMaeSegundoConjuge { get; set; }

        public DateTime DataNascimentoPaiSegundoConjuge { get; set; }

        public DateTime DataNascimentoMaeSegundoConjuge { get; set; }

        public string CpfPaiSegundoConjuge { get; set; }

        public string CpfMaeSegundoConjuge { get; set; }

    }
}
