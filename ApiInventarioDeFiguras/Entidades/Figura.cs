using System.ComponentModel.DataAnnotations;

namespace ApiInventarioDeFiguras.Entidades
{
    public class Figura
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Franquicia { get; set; }

        public virtual List <Wave> Numero_de_Serie { get; set; }
    }

    public class Wave
    {
        [Key]
        public int Id { get; set; }
        public int Ola { get; set; }
        public string Marca { get; set; }
        public virtual Figura Figura { get; set; }

    }
}
