using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4
{
    class Actividad
    {
        private String[] actividadesAutorizadas;
        private int numActividades;
        public Actividad()
        {
            actividadesAutorizadas = new string[10];
            numActividades = 0;
        }
        public void AgregarActividadautorizada(String nombre)
        {
            if(nombre != null && numActividades < actividadesAutorizadas.Length)
            {
                actividadesAutorizadas[numActividades] = nombre;
                numActividades++;
            }
        }
        public void MostrarActividadesAutorizadas()
        {
            Console.WriteLine("\nLISTA DE ACTIVIDADES AUTORIZADAS");
            for(int i = 0; i < numActividades; i++)
            {
                Console.WriteLine(i+1+"--->"+actividadesAutorizadas[i]);
            }
        }
        public String GetActividad(int i){ return actividadesAutorizadas[i]; }
        public int GetNumActividades() { return numActividades; }

    }
}
