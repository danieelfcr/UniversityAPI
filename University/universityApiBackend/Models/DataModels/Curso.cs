using System.ComponentModel.DataAnnotations;

public enum Nivel
{
    Basico,
    Intermedio,
    Avanzado
}

namespace universityApiBackend.Models.DataModels
{
    public class Curso: BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;
        
        [Required]
        public string DescripcionLarga { get; set; } = string.Empty;

        [Required]
        public string publicoObjetivo { get; set; } = string.Empty;

        [Required]
        public string Objetivos { get; set; } = string.Empty;

        [Required]
        public string Requisitos { get; set; } = string.Empty;

        [Required]
        public Nivel Nivel { get; set; }
    }
}
