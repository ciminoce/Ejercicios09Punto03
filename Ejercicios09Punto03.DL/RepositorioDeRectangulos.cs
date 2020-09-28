using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Ejercicios09Punto03.BL;

namespace Ejercicios09Punto03.DL
{
    public class RepositorioDeRectangulos
    {
        public List<Rectangulo> ListaDeRectangulos { get; set; }=new List<Rectangulo>();

        public bool EstaModificado { get; set; } = false;
        private readonly string _archivo = Environment.CurrentDirectory + @"\Rectangulos.csv";
        public RepositorioDeRectangulos()
        {
            LeerDatosDelArchivo();
        }

        private void LeerDatosDelArchivo()
        {
            /*necesito tener un objeto que lea los datos del archivo*/
            StreamReader lector=new StreamReader(_archivo);
            /*Creo un ciclo para leer mientras el lector tenga datos*/
            while (!lector.EndOfStream)
            {
                string lineaRegistro = lector.ReadLine();//Leo una linea del archivo
                Rectangulo rectangulo = ConstruirRectangulo(lineaRegistro);//obtengo el rectángulo
                /*Lo agrego a la lista*/
                ListaDeRectangulos.Add(rectangulo);
            }
            lector.Close();//Cierro el lector
        }

        private Rectangulo ConstruirRectangulo(string lineaRegistro) 
        {
            /*Primero separo los campos en un vector de string usando el método split*/
            var campos = lineaRegistro.Split(',');
            return new Rectangulo
            {
                LadoMayor = int.Parse(campos[0]),
                LadoMenor = int.Parse(campos[1])
            };
        }

        public void Agregar(Rectangulo rectangulo)
        {
            ListaDeRectangulos.Add(rectangulo);
            EstaModificado = true;
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
            EstaModificado = true;
        }

        public void Borrar(Rectangulo rectangulo)
        {
            ListaDeRectangulos.Remove(rectangulo);
            EstaModificado = true;
        }

        public void GuardarDatosEnArchivo()
        {
            if (EstaModificado)
            {
                /*Necesito un objeto que se encargue de escribir la info en el archivo*/
                StreamWriter escritor = new StreamWriter(_archivo);
                /*Tengo que recorrer la lista e ir guardando cada rectángulo en el archivo*/
                foreach (var rectangulo in ListaDeRectangulos)
                {
                    /*Obtengo la linea a escribir mediante un método*/
                    string lineaRegistro = ConstruirLinea(rectangulo);
                    /*Escribo la linea en el archivo*/
                    escritor.WriteLine(lineaRegistro);
                }
                escritor.Close();//Cierro el escritor.

            }

        }

        private string ConstruirLinea(Rectangulo rectangulo)
        {
            return $"{rectangulo.LadoMayor},{rectangulo.LadoMenor}";
        }

        public List<Rectangulo> OrdenarAscPorLadoMayor()
        {
            return ListaDeRectangulos.OrderBy(r => r.LadoMayor).ToList();
        }

        public List<Rectangulo> OrdenarDescPorLadoMayor()
        {
            return ListaDeRectangulos.OrderByDescending(r => r.LadoMayor).ToList();
        }

        public List<Rectangulo> Filtrar(int valorFiltro)
        {
            return ListaDeRectangulos.Where(r => r.LadoMayor > valorFiltro).ToList();
        }
    }
}
