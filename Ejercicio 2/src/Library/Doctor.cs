using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string NombreDoctor {get;set;}  
        public string Especialidad {get; set;}
        public bool Validacion = true;
     


        public Doctor(string name, string especialidad)
        {   
            StringBuilder stringDoctor = new StringBuilder("Creando Ficha del Doctor...\n");
            Boolean datoValido = true;
            if (string.IsNullOrEmpty(name))         //verifica que el nombre ingresado sea valido
            {
                stringDoctor.Append("Error el Nombre ingresado no es correcto. \n");
                datoValido = false;
                this.Validacion= false;
            }
            if (string.IsNullOrEmpty(especialidad))         //verifica que la especialidad ingresada sea valida
            {
                stringDoctor.Append("Error la Especialidad ingresada no es correcta. \n");
                datoValido = false;
                this.Validacion= false;
            }
            
            if (datoValido)     //Si los datos son validos, los almacena en su Property
            {
                this.NombreDoctor = name;
                this.Especialidad = especialidad;
            }
            else
            {
                Console.WriteLine(stringDoctor.ToString());     //En el caso que algun dato hubiera estado mal, solamente mostrara un texto que indica que dato estaba mal o muestra un mensaje de error.
            }
        }
        public string DatosDoctor()   //Con este metodo se obtienen los datos del Doctor en caso que los mismos hayan sido correctos.
        {
            if (Validacion == true)
            {
                return $"Nombre del Doctor: {NombreDoctor}\nEspecialidad: {Especialidad}";
            }
            return "No fue posible crear la ficha del doctor, 1 o más datos estaban mal.";
        }

    }
}