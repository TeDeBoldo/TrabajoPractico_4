using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4
{
    class Empleado
    {
        Persona persona;
        DateTime fecha;

        public Empleado(Persona persona,DateTime fecha)
        {
            this.persona = persona;
            this.fecha = fecha;
        }

        public Persona GetPersona()
        {
            return persona;
        }
        public DateTime GetFecha()
        {
            return fecha;
        }
    }
}
