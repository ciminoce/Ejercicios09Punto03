using System;
using System.Collections.Generic;
using Ejercicios09Punto03.BL;
using Ejercicios09Punto03.DL;

namespace Ejercicios09Punto03.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Capa de Prueba de los objetos");
            Rectangulo rectangulo1 = new Rectangulo { LadoMenor = 5, LadoMayor = 10 };
            Rectangulo rectangulo2 = new Rectangulo { LadoMenor = 15, LadoMayor = 30 };
            Rectangulo rectangulo3 = new Rectangulo { LadoMenor = 25, LadoMayor = 40 };
            Rectangulo rectangulo4 = new Rectangulo { LadoMenor = 5, LadoMayor = 12 };
            Rectangulo rectangulo5 = new Rectangulo { LadoMenor = 15, LadoMayor = 22 };
            RepositorioDeRectangulos repositorio=new RepositorioDeRectangulos();
            repositorio.Agregar(rectangulo1);
            repositorio.Agregar(rectangulo2);
            repositorio.Agregar(rectangulo3);
            repositorio.Agregar(rectangulo4);
            repositorio.Agregar(rectangulo5);
            List<Rectangulo> lista = repositorio.GetLista();
            foreach (var rectangulo in lista)
            {
                Console.WriteLine($"{rectangulo.ToString()}");
            }
            Console.WriteLine($"Cantidad={repositorio.GetCantidad()}");

            Console.Write("Ingrese el nro de rectángulo a dar de baja:");
            var index = int.Parse(Console.ReadLine());
            if (index>=0 && index<repositorio.GetCantidad())
            {
                repositorio.Borrar(index);
            }
            else
            {
                Console.WriteLine("Indice fuera del rango permitido");
            }
            foreach (var rectangulo in lista)
            {
                Console.WriteLine($"{rectangulo.ToString()}");
            }


            Console.WriteLine($"Cantidad={repositorio.GetCantidad()}");

            Console.Write("Ingrese el nro de rectángulo a dar de baja:");
            var index2 = int.Parse(Console.ReadLine());
            if (index2>=0 && index<repositorio.GetCantidad())
            {
                Rectangulo rectangulo = lista[index2];
                repositorio.Borrar(rectangulo);
            }
            else
            {
                Console.WriteLine("Indice fuera del rango permitido");
            }
            foreach (var rectangulo in lista)
            {
                Console.WriteLine($"{rectangulo.ToString()}");
            }


            Console.WriteLine($"Cantidad={repositorio.GetCantidad()}");
        }
    }
}
