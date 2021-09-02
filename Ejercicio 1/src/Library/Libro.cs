using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }
        /*
        En este caso la clase Libro tiene el metodo AlmacenarLibro que no es razonable que le pertenezca,
        es una responsabilidad que bien podria cumplir otra clase.
        Porque aplicando el principio SRP hay más de una razón que puede hacer que el libro cambie su ubicación
        o la forma en que se Almacenan los libros.
        Aplicando el principio SRC al crear otra clase haríamos que las responsabilidad se dividieran en una forma
        más equitativa y no tenga que hacer todo una sola función
        */

    }
}
