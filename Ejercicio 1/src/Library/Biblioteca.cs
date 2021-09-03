using System;

namespace SRP
{
    public class Biblioteca
    {

        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }
        public Libro BibliotecaLibro {get; set;}
        

        public Biblioteca(string sector, string estante, Libro libro)        
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
            this.BibliotecaLibro = libro;
            

        }

        /*public void AlmacenarLibro(string sector, string estante)
        {
            
        }*/ 

        
        public string LugarBiblioteca
        {
            get
            {
                string result = $"El libro {this.BibliotecaLibro.Titulo}, está en el sector '{this.SectorBiblioteca}', en el estante '{this.EstanteBiblioteca}'.";
                return result;
            }
            
           
        }
    }
}
