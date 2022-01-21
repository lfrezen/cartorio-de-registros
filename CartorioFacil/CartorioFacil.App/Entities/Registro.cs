using System;
using System.ComponentModel.DataAnnotations;

namespace CartorioFacil.App.Entities
{
    public abstract class Registro
    {
        public Registro()
        {
            DataRegistro = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        public DateTime DataRegistro { get; set; }
    }
}
