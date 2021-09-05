using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            libro1.LibroCaracteristicas();
            Biblioteca biblioteca = new Biblioteca();  // Se crea una instancia de la Clase Biblioteca
            
            //Aplicando los metodos de la clase Biblioteca se almacenan los libros asignandoles lugares (sector y Estante)
            biblioteca.AlmacenarLibro("A","7",libro1);
            biblioteca.AlmacenarLibro("B","3",libro2);
            
            biblioteca.LugarBiblioteca(); //Permite imprimir el lugar de los libros previamente almacenados
        }
    }
}
