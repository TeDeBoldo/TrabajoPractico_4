using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4
{
    class Ingreso
    {
        DateTime fecha;
        DateTime fechaSalida;
        Persona persona;
        double temperatura;
        String patente;
        String lugar;

        public Ingreso(DateTime fecha, Persona persona, double temperatura, String patente, String lugar)
        {
            this.fecha = fecha;
            this.persona = persona;
            this.temperatura = temperatura;
            this.patente = patente;
            this.lugar = lugar;
        }
        public Ingreso(DateTime fecha, Persona persona, double temperatura)
        {
            this.fecha = fecha;
            this.persona = persona;
            this.temperatura = temperatura;
            
        }

        public DateTime GetDateTime()
        {
            return fecha;
        }
        public Persona GetPersona()
        {
            return persona;
        }
        public double GetTemperatura()
        {
            return temperatura;
        }
        public String GetPatente()
        {
            return patente;
        }
        public String GetLugar()
        {
            return lugar;
        }
        public void setFechaSalida(DateTime fechaSalida)
        {
            this.fechaSalida = fechaSalida;
        }
        public DateTime getFechaSalida()
        {
            return fechaSalida;
        }



    }
}
