using System;

namespace Tp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int s =0;
            int eleccion;
            Persona persona1 = new Persona(42638831, "Joaquin Ficco Girardi", "Rivadavia 740", "03564 613811", "ficco20@gmail.com");
            Persona persona2 = new Persona(41523214, "Fulanito", "Cordoba 452", "03564 458965", "mail@gmail.com");
            Persona persona3 = new Persona(45236532, "Carlitos", "9 de julio 124", "03564 236585", "mail@hotmail.com");
            
            Actividad ListaActividadesAutorizadas = new Actividad();

            ListaActividadesAutorizadas.AgregarActividadautorizada("Empleado de salud");
            ListaActividadesAutorizadas.AgregarActividadautorizada("Fuerza de seguridad");
            ListaActividadesAutorizadas.AgregarActividadautorizada("Periodismo");
            ListaActividadesAutorizadas.AgregarActividadautorizada("Produccion de insumos medicos");

            RepositorioPersonasAutorizadas ListaPersonasAutorizadas = new RepositorioPersonasAutorizadas();

            PersonaAutorizada personaautorizada1 = new PersonaAutorizada(persona1, ListaActividadesAutorizadas.GetActividad(0));
            ListaPersonasAutorizadas.AgregarPersonaAutorizada(personaautorizada1);
            PersonaAutorizada personaautorizada2 = new PersonaAutorizada(persona2, ListaActividadesAutorizadas.GetActividad(1));
            ListaPersonasAutorizadas.AgregarPersonaAutorizada(personaautorizada2);
            PersonaAutorizada personaautorizada3 = new PersonaAutorizada(persona3, ListaActividadesAutorizadas.GetActividad(3));
            ListaPersonasAutorizadas.AgregarPersonaAutorizada(personaautorizada3);

            do { 
                Console.WriteLine("\n¿Que desea hacer?");
                Console.WriteLine("\nRegistrar persona ----> 1");
                Console.WriteLine("\nAutorizar persona ----> 2");
                Console.WriteLine("\nMostrar todas las actividades autorizadas ----> 3");
                Console.WriteLine("\nMostrar todas las personas autorizadas ----> 4");
                Console.WriteLine("\nCerrar el programa ---> 0");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nIngrese su nombre y apellido");
                        String nombreApellido = Console.ReadLine();
                        Console.WriteLine("\nIngrese su dni");
                        int dni = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nIngrese su domicilio");
                        String domicilio = Console.ReadLine();
                        Console.WriteLine("\nIngrese su telefono");
                        String telefono = Console.ReadLine();
                        Console.WriteLine("\nIngrese su email");
                        String email = Console.ReadLine();

                        Console.WriteLine("\nElija la actividad que realiza");
                        ListaActividadesAutorizadas.MostrarActividadesAutorizadas();
                        do
                        {
                            if (s > 0)
                            {
                                Console.WriteLine("Ingrese correctamente el numero de la actividad");
                            }
                            eleccion = int.Parse(Console.ReadLine());
                            s++;
                        } while (eleccion < 1 || eleccion > ListaActividadesAutorizadas.GetNumActividades());
                        

                        Persona persona = new Persona(dni, nombreApellido, domicilio, telefono, email);
                        PersonaAutorizada personaAutorizada = new PersonaAutorizada(persona, ListaActividadesAutorizadas.GetActividad(eleccion-1));
                        ListaPersonasAutorizadas.AgregarPersonaAutorizada(personaAutorizada);

                        Console.WriteLine("\nLa persona se ha registrado correctamente");
                        Console.WriteLine("\nPresiones una tecla para continuar");
                        Console.ReadLine();

                        break;
                    case 2:
                        Console.WriteLine("\nIngrese el dni");
                        dni = int.Parse(Console.ReadLine());
                        int senial = 0;

                        for (int i = 0; i < ListaPersonasAutorizadas.GetNumPersonas(); i++)
                        {
                            if (dni == ListaPersonasAutorizadas.GetPersona(i).GetPersona().GetDni())
                            {
                                Console.WriteLine("\nLa persona esta autorizada a circular");
                                Console.WriteLine("\n¿Desea ver la informacion de la persona?\nSi --> 1\nNo --> 0");

                                if (int.Parse(Console.ReadLine()) == 1)
                                {
                                    Console.WriteLine(ListaPersonasAutorizadas.GetPersona(i).MostrarPersona());
                                }
                                senial = 1;
                                Console.WriteLine("\nPresiones una tecla para continuar");
                                Console.ReadLine();
                            }
                        }
                        if (senial == 0)
                        {
                            Console.WriteLine("\nLa persona no esta autorizada a circular");
                            Console.WriteLine("\nPresiones una tecla para continuar");
                            Console.ReadLine();
                        }

                        break;

                    case 3:
                        ListaActividadesAutorizadas.MostrarActividadesAutorizadas();
                        Console.WriteLine("\nPresiones una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 4:
                        ListaPersonasAutorizadas.MostrarListaPersonasAutorizadas();
                        Console.WriteLine("\nPresiones una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 0:

                        break;
                }
            } while (opcion != 0);
        }
    }
}
