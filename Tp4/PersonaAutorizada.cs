using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4
{
    class PersonaAutorizada
    {
        private Persona persona;
        private String actividad;
        public PersonaAutorizada(Persona persona,String actividad)
        {
            this.persona = persona;
            this.actividad = actividad;
        }
        public Persona GetPersona() { return persona; }
        public String MostrarPersona()
        {
            return "\nNombre y apellido:" + persona.GetNombreApellido() +
                "\nDNI:" + persona.GetDni() +
                "\nDomicilio:" + persona.GetDomicilio() +
                "\nTelefono:" + persona.GetTelefono() +
                "\nEmail:" + persona.GetEmail() +
                "\nActividad:" + actividad;
        }
    }
}
