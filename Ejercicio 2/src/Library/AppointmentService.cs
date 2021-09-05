using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        private static int count =1;
        public static int Count 
        {
            get
            {
                return AppointmentService.count;
            }
        }
        public string ConsultaId()
        {
            /*El identificador de la consulta esta compuesto por la mitad de las letras que compone la especialidad del Doctor, 
            y a su vez se le agrega un numero de referencia el cual esta determinado por un contador, el cual indica la cantidad de 
            instancias de la clase AppoinmentService creadas, de modo tal que no se repita un mismo numero.*/
            string consultaId = "";
            string contadorStr = "";
            foreach (char letra in AppointmentService.Count.ToString())
            {
                contadorStr += letra;
            }
            for (int i = 0; i < pDoctor.Especialidad.Length/2; i++)
            {
                consultaId += pDoctor.Especialidad[i];
            }
            consultaId = $"{consultaId}-{contadorStr}";
            return consultaId;
        }
        public string AppointmentPlace {get; set;}
        public Doctor pDoctor {get;set;}
        public Paciente pPaciente {get;set;}
        private string result {get;set;}  
    
        public AppointmentService()
        {
            AppointmentService.count++;  //incrementador para el contador
        }


        public string CreateAppointment(Paciente paciente, DateTime date, string appointmentPlace, Doctor doctor)
        {
            this.pDoctor = doctor;
            this.pPaciente = paciente;
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            StringBuilder stringBuilder1 = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;
            if (string.IsNullOrEmpty(appointmentPlace))
            {
                stringBuilder1.Append("Error el Lugar ingresado no es correcto. \n");
                isValid = false;
            }
            else
            {
                this.AppointmentPlace = appointmentPlace;
            }

            if (isValid == true && doctor.Validacion == true && paciente.Validacion ==true)
            {
                stringBuilder.Append($"Appointment Scheduled\nID para la cunsulta: {this.ConsultaId()}");
            }
            else
            {
                stringBuilder1.Append("Appointment Canceled");
                this.result = stringBuilder1.ToString();
                return stringBuilder1.ToString();
            }
            this.result = stringBuilder.ToString();
            return stringBuilder.ToString() ;

        }

        public void AgendaConsulta()   //Con este metodo se puede acceder a imprimir 
        {
            Console.WriteLine(this.result);
        }

    }
}
