using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4
{
    class RepositorioPersonasAutorizadas
    {
        private PersonaAutorizada[] ListaPersonasAutorizadas = new PersonaAutorizada[10];
        private int numPersonas = 0;
        public void AgregarPersonaAutorizada(PersonaAutorizada persona)
        {
            if ( persona != null && numPersonas < ListaPersonasAutorizadas.Length)
            {
                ListaPersonasAutorizadas[numPersonas] = persona;
            }
            numPersonas++;
        }
        public void MostrarListaPersonasAutorizadas()
        {
            Console.WriteLine("\nLISTA DE PERSONAS AUTORIZADAS");
            for(int i = 0; i < numPersonas; i++)
            {
                Console.WriteLine(ListaPersonasAutorizadas[i].MostrarPersona());
            }
        }
        public PersonaAutorizada GetPersona(int i){ return ListaPersonasAutorizadas[i];}
        public int GetNumPersonas(){return numPersonas;}

    }
}
