using Microsoft.AspNetCore.Identity;
using System.Numerics;

namespace ApiInventarioDeFiguras.Entidades
{
    public class Wave
    {
        public long Numero_de_Serie { get; set; }
        public int Ola { get; set; }
        public string Marca { get; set; }
        public virtual Figura Figura { get; set; }
         
    }
}
