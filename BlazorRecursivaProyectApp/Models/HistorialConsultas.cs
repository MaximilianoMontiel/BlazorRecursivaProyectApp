using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorRecursivaProyectApp.Models
{
    public class HistorialConsultas
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Signo { get; set; }

        [Required]
        public string FechaConsulta { get; set; }
    }
}
