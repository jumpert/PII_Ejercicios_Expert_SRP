using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crean los 2 pacientes como figuraban en la plantilla y se le agrega la edad, pero esta vez con una clase llamada Paciente
            Paciente paciente1 = new Paciente("Steven Jhonson", "986782342", "5555-555-555", "54");
            Console.WriteLine(paciente1.DatosPaciente());
            Paciente paciente2 = new Paciente("Ralf Manson", "", "5555-555-555", "19");
            Console.WriteLine(paciente2.DatosPaciente());
            //Se crean los 2 doctores al igual que en la plantilla, pero esta vez con la clase doctor y se le agrega especialidad
            Doctor doc1 = new Doctor("John Doe","Oftalmología");
            Console.WriteLine(doc1.DatosDoctor());
            Doctor doc2 = new Doctor("", "Cardiologa");
            Console.WriteLine(doc2.DatosDoctor());
            //Utilizando la Clase AppointmentService de la plantilla, y luego de realizarle los mantenimientos correspondientes se crean 2 consultas
            AppointmentService consulta1 = new AppointmentService();
            consulta1.CreateAppointment(paciente1, DateTime.Now, "Wall Street", doc1);
            consulta1.AgendaConsulta();
            Console.WriteLine(consulta1.ConsultaId());
            AppointmentService consulta2 = new AppointmentService();
            consulta2.CreateAppointment(paciente2, DateTime.Now, "Queen Street", doc2);
            consulta2.AgendaConsulta();
            Console.WriteLine(consulta2.ConsultaId());
            


            /*
            Datos de la Plantilla: 
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
            */
        }
    }
}
