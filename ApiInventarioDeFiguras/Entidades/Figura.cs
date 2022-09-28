using System.ComponentModel.DataAnnotations;

namespace ApiInventarioDeFiguras.Entidades
{
    public class Figura
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage="Se requiere nombre de la figura ")]
        [StringLength(40, MinimumLength = 3)]
        public string Name { get; set; }

        public string Franquicia { get; set; }

        public virtual List <Wave> Wave { get; set; }
    }

    public class Wave
    {
        [Key]
        public int Id { get; set; }
        public int Ola { get; set; }
        public string Marca { get; set; }

    }
}
