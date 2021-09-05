using System;
using System.Collections;
using System.Collections.Generic;

namespace SRP
{
    public class Biblioteca
    {

        public List<string> SectorBiblioteca = new List<string>();  //Crea una lista que almacena los sectores de la biblioteca que se van ocupando
        public List<string> EstanteBiblioteca = new List<string>();  //Crea una lista que almacena los estantes de la biblioteca que se van ocupando
        public Libro BibliotecaLibro {get; set;} //Esta propiedad recibe como parametro una instancia de la clase Libro
        
        public Biblioteca()
        {
        }

        public void AlmacenarLibro(string sector, string estante, Libro libro)   // Metodo para almacenar los libros, les asigna un sector y un estante
        {
            SectorBiblioteca.Add(sector);
            EstanteBiblioteca.Add(estante);
            this.BibliotecaLibro = libro;
            LibrosAlmacenados.Add(libro);
        } 

        public List<Libro> LibrosAlmacenados = new List<Libro>();  //Crea una lista que almacena los Libros de la biblioteca que se van ocupando

        public void LugarBiblioteca() //Este propiedad se utiliza para devolver la posición en que se encuentra el libro
        {
            int counter = LibrosAlmacenados.Count;
            for (int i = 0; i < counter; i++ )
            {
                string result = $"El libro {LibrosAlmacenados[i].Titulo}, está en el sector '{SectorBiblioteca[i]}', en el estante '{EstanteBiblioteca[i]}'.";     
                Console.WriteLine(result);
            }
        }
    }
}
