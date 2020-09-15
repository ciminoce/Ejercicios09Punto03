using System.Collections.Generic;
using Ejercicios09Punto03.BL;

namespace Ejercicios09Punto03.DL
{
    public class RepositorioDeRectangulos
    {
        public List<Rectangulo> ListaDeRectangulos { get; set; }=new List<Rectangulo>();

        public RepositorioDeRectangulos()
        {
            Rectangulo rectangulo1 = new Rectangulo { LadoMenor = 5, LadoMayor = 10 };
            Rectangulo rectangulo2 = new Rectangulo { LadoMenor = 15, LadoMayor = 30 };
            Rectangulo rectangulo3 = new Rectangulo { LadoMenor = 25, LadoMayor = 40 };
            Rectangulo rectangulo4 = new Rectangulo { LadoMenor = 5, LadoMayor = 12 };
            Rectangulo rectangulo5 = new Rectangulo { LadoMenor = 15, LadoMayor = 22 };
            
            Agregar(rectangulo1);
            Agregar(rectangulo2);
            Agregar(rectangulo3);
            Agregar(rectangulo4);
            Agregar(rectangulo5);

        }
        public void Agregar(Rectangulo rectangulo)
        {
            ListaDeRectangulos.Add(rectangulo);
        }

        public int GetCantidad()
        {
            return ListaDeRectangulos.Count;
        }

        public List<Rectangulo> GetLista()
        {
            return ListaDeRectangulos;
        }

        public void Borrar(int index)
        {
            ListaDeRectangulos.RemoveAt(index);
        }

        public void Borrar(Rectangulo rectangulo)
        {
            ListaDeRectangulos.Remove(rectangulo);
        }
    }
}
