using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4
{
    class RepositorioIngresos
    {

        List<Ingreso> ListaIngresos = new List<Ingreso>();
        int numIngresos = 0;
        public void AgregarIngreso(Ingreso ingreso)
        {
            ListaIngresos.Add(ingreso);
            numIngresos++;
        }

        public Ingreso GetIngreso(int i)
        {
            return ListaIngresos[i];
        }

        public int GetNumIngresos()
        {
            return numIngresos;
        }
        
    }
}
