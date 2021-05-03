using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4
{
    class Persona
    {
        private int dni;
        private String nombreApellido;
        private String domicilio;
        private String telefono;
        private String email;

        public Persona(int dni, String nombreApellido, String domicilio, String telefono, String email)
        {
            this.dni = dni;
            this.nombreApellido = nombreApellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.email = email;
        }

        public int GetDni() { return dni; }
        public void SetDni(int dni) { this.dni = dni; }
        public String GetNombreApellido() { return nombreApellido; }
        public void SetNombreApellido(String nombreApellido) { this.nombreApellido = nombreApellido; }
        public String GetDomicilio() { return domicilio; }
        public void SetDomicilio(String domicilio) { this.domicilio = domicilio; }
        public String GetTelefono() { return telefono; }
        public void SetTelefono(String telefono) { this.telefono = telefono; }
        public String GetEmail() { return email; }
        public void SetEmail(String email) { this.email = email; }
    }
}
