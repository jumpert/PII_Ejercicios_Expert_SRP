using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void LibroCaracteristicas()      //Permite acceder a las caracteristicas de cada libro (titulo, autor y Codigo)
        {
            Console.WriteLine($"El título del libro es {this.Titulo}, fue escrito por {this.Autor}.");
        }

    }
}
