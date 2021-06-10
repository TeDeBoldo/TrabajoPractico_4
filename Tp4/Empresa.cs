using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tp4
{
    class Empresa
    {
        private String razonSocial;
        private int cuit;
        private String domicilio;
        private String localidad;
        private String email;
        private String telefono;
        private String actividad;
        private List<Empleado> ListaEmpleados = new List<Empleado>();
        int numEmpleados = 0;
        public Empresa(String razonSocial, int cuit, String domicilio, String localidad, String email, String telefono, String actividad)
        { 
            this.razonSocial = razonSocial;
            this.cuit = cuit;
            this.domicilio = domicilio;
            this.localidad = localidad;
            this.email = email;
            this.telefono = telefono;
            this.actividad = actividad;
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            ListaEmpleados.Add(empleado);
            numEmpleados++;
        }
        public void EliminarEmpleado(Empleado empleado)
        {
            ListaEmpleados.Remove(empleado);
            numEmpleados--;
        }
        
        public void MostrarListaEmpleados()
        {

            if (numEmpleados > 0)
            {
                Console.WriteLine("\nLISTA DE EMPLEADOS DE LA EMPRESA");
                for (int i = 0; i < numEmpleados; i++)
                {
                    Console.WriteLine(ListaEmpleados[i].GetPersona().MostrarPersona() + "\nHabilitado hasta:" + ListaEmpleados[i].GetFecha());
                }
            }
            else
            {
                Console.WriteLine("\nLa empresa no tiene ningun empleado");
            }            
        }

        public int Getcuit()
        {
            return cuit;
        }
        public int GetNumEmpleados()
        {
            return numEmpleados;
        }
        public Empleado GetEmpleado(int i)
        {
            return ListaEmpleados[i]; 
        }
        public String MostrarEmpresa()
        {
            return "\nRazon social:" + razonSocial +
                "\nCuit:" + cuit +
                "\nDomicilio:" + domicilio +
                "\nLocalidad:" + localidad +
                "\nEmail:" + email +
                "\nTelefono" + telefono +
                "\nActividad:" + actividad;
        }
     
      
    }


}
