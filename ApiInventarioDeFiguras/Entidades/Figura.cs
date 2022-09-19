namespace ApiInventarioDeFiguras.Entidades
{
    public class Figura
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Franquicia { get; set; }

        public virtual List <Wave> Marca { get; set; }
    }
}
