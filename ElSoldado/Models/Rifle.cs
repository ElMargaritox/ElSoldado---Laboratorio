using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado.Models
{
    public class Rifle : Arma
    {
        public Rifle()
        {
            Nombre = "Rifle";
            Balas = 5;
        }
        public override void Disparar()
        {
            Console.WriteLine("El Sonido De Disparo Es: PUM!");

        }
    }
}
