using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado.Models
{
    public class Soldado
    {
        
        public Soldado() { }

        public virtual void RecogerArma(Arma arma)
        {
            _arma = arma;
        }

        public void DejarArma()
        {
            Console.WriteLine("Has Dejado El Arma: {0}", _arma.Nombre);
            _arma = null;

        }

        public virtual void Disparar() { }

        public void VerArma()
        {
            Console.WriteLine("El Arma Que Tienes En La Mano Es: {0}", _arma.Nombre);
        }

        public bool TieneArma()
        {
            Console.Clear();
            if (_arma == null)
            {
                Console.WriteLine("No posees Ningun Arma");
            }
            else
            {
                return true;
            }
            return false;
            
        }

        public  void Menu()
        {
            bool salir = false;
            do
            {

            
            Console.WriteLine("-== Bienvenido al campo de entrenamiento, Soldado ==-");
            Console.WriteLine("¿Que Desea Hacer?");
            Console.WriteLine(" 1 - Recoger Arma");
            Console.WriteLine(" 2 - Dejar Arma");
            Console.WriteLine(" 3 - Disparar");
            Console.WriteLine(" 4 - Ver Arma En Uso");
            Console.WriteLine(" 5 - Salir");
                int.TryParse(Console.ReadLine(), out int opcion);

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        SeleccionarArma(salir);
                        break;
                    case 2:
                        Console.Clear();

                        if (TieneArma())
                        {
                            DejarArma();
                        }
                        break;
                    case 3:
                        if (TieneArma())
                        {
                            Console.WriteLine("Has Disparado El Arma: {0}", _arma.Nombre); Disparar();
                        }
                        break;
                    case 4:
                        if (TieneArma())
                        {
                            VerArma();
                        }
                        break;
                    case 5:
                        salir = true;
                        break;
                }

               
            } while (!salir);
        }


        public void SeleccionarArma(bool salir)
        {
            do
            {

                Console.WriteLine("1 - Revolver");
                Console.WriteLine("2 - Rifle");
                Console.WriteLine("3 - Escopeta");
                Console.WriteLine("4 - Volver");
                int.TryParse(Console.ReadLine(), out int opcion);


                switch (opcion)
                {
                    case 1:
                        _arma = new Revolver(); RecogerArma(_arma); salir = true;
                        break;
                    case 2:
                        _arma = new Rifle(); RecogerArma(_arma); salir = true;
                        break;
                    case 3:
                        _arma = new Escopeta(); RecogerArma(_arma); salir = true;
                        break;
                    case 4:
                        salir = true;
                        return;
                        
                }
                Console.Clear();
                Console.WriteLine("Has Seleccionado: {0}", _arma.Nombre);


            } while (!salir);
        }
        

        private Arma _arma;
    }
}
