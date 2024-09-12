using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErosionLunar.Prototipos.Ejercicio01.DatosDeUnaPersona
{
    internal class DatosDeUnaPersonaModel
    {
        private List<Persona> ListaPersonas = new List<Persona>();
        public string PersonaIngresada(Persona persona)
        {
            //TODO: Validar los datos y hacer algo
            if(persona.DNI < 1_000_000 || persona.DNI > 99_999_999)
            {
                return "El DNI debe de tener 7-8 dígitos.";
            }
            if (string.IsNullOrWhiteSpace(persona.Nombre))
            {
                return "El nombre es requerido.";
            }

            if (persona.Nombre.Length > 50)
            {
                return "El nombre debe de tener hasta 50 caracteres.";
            }
            if (string.IsNullOrWhiteSpace(persona.Apellido))
            {
                return "El apellido es requerido.";
            }
            if(persona.FechaNacimiento > DateTime.Now)
            {
                return "La fecha de nacimiento no puede ser mayor a la actual.";
            }
            ListaPersonas.Add(persona);

            //No quiero personas repetidos
            //=> No puede haber dos personas con el mismo DNI

            foreach( var personaGuardada in ListaPersonas)
            {
                if(personaGuardada.DNI == persona.DNI)
                {
                    return $"Ya se ha ingresado una persona con DNI {persona.DNI}";
                }
            }

            return "Hay un problema con la persona ingresada."; // Devolver un mensaje de error o nulo para indicar todo OK
        }
    }
}
