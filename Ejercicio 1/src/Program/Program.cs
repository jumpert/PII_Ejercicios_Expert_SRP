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
            Biblioteca lugar1 = new Biblioteca("A","7",libro1);
            Biblioteca lugar2 = new Biblioteca("B","3",libro2);
            Console.WriteLine(lugar1.LugarBiblioteca);
            
            

        }
    }
}
