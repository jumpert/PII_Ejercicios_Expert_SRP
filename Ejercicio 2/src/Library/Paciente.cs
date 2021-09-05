using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
        public string NombrePaciente {get;set;}
        public string IdPaciente {get; set;}
        public string TelPaciente {get; set;}
        public string Edad {get; set;}
        public bool Validacion = true;


        public Paciente(string name, string id, string phoneNumber, string age)
        {   
            StringBuilder stringPaciente = new StringBuilder("Creando ficha de paciente...\n");
            Boolean datoValido = true;
            if (string.IsNullOrEmpty(name))
            {
                stringPaciente.Append("Error, el nombre ingresado no es correcto. \n");     //verifica que el nombre ingresado sea valido
                datoValido = false;
                this.Validacion= false;
            }
            if (string.IsNullOrEmpty(id))
            {
                stringPaciente.Append("Error, el ID ingresado no es correcto. \n");     //verifica que el ID ingresado sea valido
                datoValido = false;
                this.Validacion= false;
            }
            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringPaciente.Append("Error, el numero de telefono ingresado no es correcto. \n");     //verifica que el telefono ingresado sea valido
                datoValido = false;
                this.Validacion= false;
            }
            if (string.IsNullOrEmpty(age))
            {
                stringPaciente.Append("Error, la edad ingresada no es correcta. ");     //verifica que la edad ingresada sea valida
                datoValido = false;
                this.Validacion= false;
            }
            if (datoValido)         //Si los datos ingresados fueron correctos, los asigna a su Property correspondiente
            {
                this.NombrePaciente = name;
                this.IdPaciente = id;
                this.TelPaciente = phoneNumber;
                this.Edad = age;
            }
            else
            {
                Console.WriteLine(stringPaciente.ToString());   //En el caso que algun dato hubiera estado mal, solamente mostrara un texto que indica que dato estaba mal
            }
        }
        public string DatosPaciente()  //Con este metodo se obtienen los datos del Paciente en caso que los mismos hayan sido correctos, o muestra un mensaje de error.
        {
            if (this.Validacion ==true)
            {
                return $"Nombre del Paciente: {NombrePaciente}\nC.I.: {IdPaciente}\nTel.: {TelPaciente}\nEdad: {Edad}";
            }
            return "No fue posible crear la ficha del paciente, 1 o más datos estaban mal.";
        }

    }
}
