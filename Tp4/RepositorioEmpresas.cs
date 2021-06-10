using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4
{
    class RepositorioEmpresas
    {
        List<Empresa> ListaEmpresas = new List<Empresa>();
        int numEmpresas = 0;

        public void AgregarEmpresa(Empresa empresa)
        {
            ListaEmpresas.Add(empresa);
            numEmpresas++;
        }

        public Empresa GetEmpresa(int i)
        {
            return ListaEmpresas[i];
        }

        public int getNumeroEmpresas()
        {
            return numEmpresas;
        }
        public void MostrarEmpresas()
        {
            Console.WriteLine("\nLISTA DE EMPRESAS");
            for(int i = 0; i < numEmpresas; i++)
            {
                Console.WriteLine(ListaEmpresas[i].MostrarEmpresa());
            }
        }
    }
}
