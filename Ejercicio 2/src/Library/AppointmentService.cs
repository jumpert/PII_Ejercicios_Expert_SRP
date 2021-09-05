using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        /*Este metodo contiene todas las instrucciones que realiza la clase, como propiamente la letra del ejercicio dice
        hay muchas razones por las cuales la consulta puede cambiar, porque se le puede agregar algun dato del paciente, 
        porque puede cambiar la forma de agendarse o porque puede que algo más cambie.
        Por esta razon no es practico tener todo en una misma clase, deberia aplicar el principio SRC y agregar 1 o 2 clases más,
        de forma tal que las responsabilidades queden divididas. Y a la hora de modificar algo sea más facil hacerle mantenimiento.*/

        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
