using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado.Models
{
    public class Escopeta : Arma
    {
        public Escopeta()
        {
            Nombre = "Escopeta";
            Balas = 8;
        }

        public override void Disparar()
        {
            Console.WriteLine("El Sonido De Disparo Es: PAWN!");
        }
    }
}
