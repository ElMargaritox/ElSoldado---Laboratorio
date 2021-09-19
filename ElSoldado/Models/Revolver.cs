using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado.Models
{
    public class Revolver : Arma
    {
        public Revolver()
        {
            Nombre = "Revolver";
            Balas = 6;
        }
        public override void Disparar()
        {
            Console.WriteLine("El Sonido De Disparo Es: Piu Piu");
            
        }
    }
}
