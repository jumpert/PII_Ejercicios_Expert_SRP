using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Actualmente el programa tiene todas sus responsabilidades referente a crear la consulta en la Clase AppointService
            lo cual funciona bien, pero a la hora de la efectividad no es lo mejor, ya que es una clase sola la que tiene todas las responsabilidades.*/
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand"); 
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
        }
    }
}
