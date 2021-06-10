using System;

namespace Tp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int s;
            int eleccion;

            /* Tengo dudas con el planteamiento, lo tome como que cada persona pasaba a ser un empleado y 
             * para su autorizacion utilize la lista de empleados de cada empresa; de esta manera me quedaron al aire las clases PersonaAutorizada y RepositorioPersonasAutorizadas,
             * ademas de quedar descontinuado Registra Persona, Autoriza Persona y Mostrar lista de personas autorizadas
            */

            /* Machete para corroborar -> Empresa: Cruz Azul -> Cuit: 22556633 / Empleados: dni: 44112233 y dni: 22114466
             *                            Empresa: Radiocanal -> Cuit: 33224455 / Emleados: dni: 33556644
             *                            Empresa: Segurity -> Cuit: 11553322 / Empleados: dni: 23556622
            */
            Persona persona1 = new Persona(33112244, "Jose Perez", "Calle 574", "03564 445511", "mailprueba@gmail.com");
            Persona persona2 = new Persona(41523214, "Fulanito", "Cordoba 452", "03564 458965", "mail@gmail.com");
            Persona persona3 = new Persona(45236532, "Carlitos", "9 de julio 124", "03564 236585", "mail@hotmail.com");

            Persona persona4 = new Persona(44112233, "Fernando Rodriguez", "9 de julio 124", "03564 236585", "mail@hotmail.com");
            Persona persona5 = new Persona(33556644, "Joaquin Salvio", "Catamarca 632", "03564 556688", "mail@gmail.com");
            Persona persona6 = new Persona(22114466, "Analia Salomon", "Peru 2500", "03564 448899", "mail@hotmail.com");
            Persona persona7 = new Persona(23556622, "Sofia Ceballos", "Rivadavia 456", "03564 331155", "mail@gmail.com");

            Actividad ListaActividadesAutorizadas = new Actividad();

            ListaActividadesAutorizadas.AgregarActividadautorizada("Salud");
            ListaActividadesAutorizadas.AgregarActividadautorizada("Seguridad");
            ListaActividadesAutorizadas.AgregarActividadautorizada("Periodismo");
            ListaActividadesAutorizadas.AgregarActividadautorizada("Produccion de insumos medicos");

            RepositorioPersonasAutorizadas ListaPersonasAutorizadas = new RepositorioPersonasAutorizadas();

            
            PersonaAutorizada personaautorizada1 = new PersonaAutorizada(persona1, ListaActividadesAutorizadas.GetActividad(0));
            ListaPersonasAutorizadas.AgregarPersonaAutorizada(personaautorizada1);
            PersonaAutorizada personaautorizada2 = new PersonaAutorizada(persona2, ListaActividadesAutorizadas.GetActividad(1));
            ListaPersonasAutorizadas.AgregarPersonaAutorizada(personaautorizada2);
            PersonaAutorizada personaautorizada3 = new PersonaAutorizada(persona3, ListaActividadesAutorizadas.GetActividad(3));
            ListaPersonasAutorizadas.AgregarPersonaAutorizada(personaautorizada3);

            RepositorioEmpresas ListaEmpresas = new RepositorioEmpresas();

            Empresa empresa1 = new Empresa("Cruz azul",22556633,"9 de Julio 1501","San Francisco","cruzazul@hotmail.com","426688", ListaActividadesAutorizadas.GetActividad(0));
            ListaEmpresas.AgregarEmpresa(empresa1);
            Empresa empresa2 = new Empresa("Radiocanal",33224455,"25 de mayo 1000","San Francisco","radiocanal@gmail.com","425588", ListaActividadesAutorizadas.GetActividad(2));
            ListaEmpresas.AgregarEmpresa(empresa2);
            Empresa empresa3 = new Empresa("Segurity",11553322,"Salta 550","San Francisco","segurity@gmail.com","423311", ListaActividadesAutorizadas.GetActividad(1));
            ListaEmpresas.AgregarEmpresa(empresa3);


            DateTime fecha1 = new DateTime(2021, 06, 20);
            DateTime fecha2 = new DateTime(2021, 06, 7);
            DateTime fecha3 = new DateTime(2021, 06, 5);
            DateTime fecha4 = new DateTime(2021, 07, 5);

            Empleado empleado1 = new Empleado(persona4,fecha1);
            Empleado empleado2 = new Empleado(persona5,fecha2);
            Empleado empleado3 = new Empleado(persona6,fecha3);
            Empleado empleado4 = new Empleado(persona7,fecha4);

            empresa1.AgregarEmpleado(empleado1);
            empresa1.AgregarEmpleado(empleado3);
            empresa2.AgregarEmpleado(empleado2);
            empresa3.AgregarEmpleado(empleado4);

            do { 
                Console.WriteLine("\n¿Que desea hacer?");
                Console.WriteLine("\nRegistrar persona ----> 1");
                Console.WriteLine("\nAutorizar persona ----> 2");
                Console.WriteLine("\nRegistrar empresa ----> 3");
                Console.WriteLine("\nRegistrar empleado de una empresa ----> 4");
                Console.WriteLine("\nAutorizar empleado de una empresa ----> 5");
                Console.WriteLine("\nDar de baja empleado de una empresa ----> 6");
                Console.WriteLine("\nMostrar empresas registradas ----> 7");
                Console.WriteLine("\nMostrar empleados de una empresa ----> 8");
                Console.WriteLine("\nMostrar todas las actividades autorizadas ----> 9");
                Console.WriteLine("\nMostrar todas las personas autorizadas ----> 10");
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

                        s = 0;
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
                        Console.WriteLine("\nIngrese la razon social");
                        String razonSocial= Console.ReadLine();
                        Console.WriteLine("\nIngrese el cuit");
                        int cuit = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nIngrese el domicilio");
                        domicilio = Console.ReadLine();
                        Console.WriteLine("\nIngrese la localidad");
                        String localidad = Console.ReadLine();
                        Console.WriteLine("\nIngrese el email");
                        email = Console.ReadLine();
                        Console.WriteLine("\nIngrese el telefono");
                        telefono = Console.ReadLine();

                        Console.WriteLine("\nElija la actividad que realiza");
                        ListaActividadesAutorizadas.MostrarActividadesAutorizadas();

                        s = 0;
                        do
                        {
                            if (s > 0)
                            {
                                Console.WriteLine("Ingrese correctamente el numero de la actividad");
                            }
                            eleccion = int.Parse(Console.ReadLine());
                            s++;
                        } while (eleccion < 1 || eleccion > ListaActividadesAutorizadas.GetNumActividades());

                        Empresa empresa = new Empresa(razonSocial, cuit, domicilio, localidad, email, telefono, ListaActividadesAutorizadas.GetActividad(eleccion - 1));
                        ListaEmpresas.AgregarEmpresa(empresa);

                        Console.WriteLine("\nLa empresa se ha registrado correctamente");
                        Console.WriteLine("\nPresiones una tecla para continuar");
                        Console.ReadLine();

                        break;

                    case 4:

                        Console.WriteLine("\nIngrese el cuit de la empresa");
                        cuit = int.Parse(Console.ReadLine());

                        senial = 0;
                        for(int i = 0; i < ListaEmpresas.getNumeroEmpresas(); i++)
                        {

                            if(cuit == ListaEmpresas.GetEmpresa(i).Getcuit())
                            {
                                Console.WriteLine("\nIngrese el nombre y apellido");
                                nombreApellido = Console.ReadLine();
                                Console.WriteLine("\nIngrese el dni");
                                dni = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nIngrese el domicilio");
                                domicilio = Console.ReadLine();
                                Console.WriteLine("\nIngrese el telefono");
                                telefono = Console.ReadLine();
                                Console.WriteLine("\nIngrese el email");
                                email = Console.ReadLine();
                                Console.WriteLine("\nIngrese la fecha limite del permiso");
                                DateTime fecha = DateTime.Parse(Console.ReadLine());

                                Persona persona8 = new Persona(dni, nombreApellido, domicilio, telefono, email);
                                Empleado empleado = new Empleado(persona8,fecha);

                                ListaEmpresas.GetEmpresa(i).AgregarEmpleado(empleado);

                                Console.WriteLine("\nEl empleado se ha registrado correctamente");
                                Console.WriteLine("\nPresiones una tecla para continuar");
                                Console.ReadLine();

                                senial = 1;
                            }
                        }
                        if(senial == 0)
                        {
                            Console.WriteLine("\nNo hay ninguna empresa registrada con ese cuit");
                            Console.WriteLine("\nPresiones una tecla para continuar");
                            Console.ReadLine();
                        }

                        break;

                    case 5:

                        Console.WriteLine("\nIngrese el dni");
                        dni = int.Parse(Console.ReadLine());

                        senial = 0;
                        for(int i = 0; i < ListaEmpresas.getNumeroEmpresas(); i++)
                        {
                            for(int j = 0; j < ListaEmpresas.GetEmpresa(i).GetNumEmpleados(); j++)
                            {
                                if (dni == ListaEmpresas.GetEmpresa(i).GetEmpleado(j).GetPersona().GetDni() && DateTime.Now < ListaEmpresas.GetEmpresa(i).GetEmpleado(j).GetFecha()) 
                                {
                                    Console.WriteLine("\nLa persona esta autorizada a circular");
                                    senial = 1;

                                    Console.WriteLine("\n¿Desea ver la informacion de la persona?\nSi --> 1\nNo --> 0");
                                    if (int.Parse(Console.ReadLine()) == 1)
                                    {
                                        Console.WriteLine(ListaEmpresas.GetEmpresa(i).GetEmpleado(j).GetPersona().MostrarPersona()+"\n" + "\nEmpresa para la cual trabaja" + "\n" +
                                            ListaEmpresas.GetEmpresa(i).MostrarEmpresa());
                                    }

                                    Console.WriteLine("\nPresiones una tecla para continuar");
                                    Console.ReadLine();
                                }
                            }

                        }
                        if(senial == 0)
                        {
                            Console.WriteLine("\nLa persona no esta autorizada a circular");
                            Console.WriteLine("\nPresiones una tecla para continuar");
                            Console.ReadLine();
                        }

                        break;

                    case 6:

                        Console.WriteLine("\nIngrese el cuit de la empresa");
                        cuit = int.Parse(Console.ReadLine());

                        senial = 0;
                        for(int i = 0; i < ListaEmpresas.getNumeroEmpresas(); i++)
                        {
                            if(cuit == ListaEmpresas.GetEmpresa(i).Getcuit())
                            {
                                senial = 1;
                                Console.WriteLine("\nIngrese el dni del empleado");
                                dni = int.Parse(Console.ReadLine());

                                for(int j = 0; j < ListaEmpresas.GetEmpresa(i).GetNumEmpleados();j++)
                                {
                                    if(dni == ListaEmpresas.GetEmpresa(i).GetEmpleado(j).GetPersona().GetDni())
                                    {
                                        senial = 2;
                                        ListaEmpresas.GetEmpresa(i).EliminarEmpleado(ListaEmpresas.GetEmpresa(i).GetEmpleado(j));
                                        Console.WriteLine("\nEl empleado se ha dado de baja correctamente");
                                        Console.WriteLine("\nPresiones una tecla para continuar");
                                        Console.ReadLine();
                                    }
                                }
                                if(senial == 1)
                                {
                                    Console.WriteLine("\nNo hay ningun empleado con ese dni");
                                    Console.WriteLine("\nPresiones una tecla para continuar");
                                    Console.ReadLine();
                                }
                            }
                        }
                        if(senial == 0)
                        {
                            Console.WriteLine("\nNo hay ninguna empresa con ese cuit");
                            Console.WriteLine("\nPresiones una tecla para continuar");
                            Console.ReadLine();
                        }
                        break;

                    case 7:
                        ListaEmpresas.MostrarEmpresas();
                        Console.WriteLine("\nPresiones una tecla para continuar");
                        Console.ReadLine();
                        break;

                    case 8:

                        Console.WriteLine("\nIngrese el cuit de la empresa");
                        cuit = int.Parse(Console.ReadLine());

                        senial = 0;
                        for (int i = 0; i < ListaEmpresas.getNumeroEmpresas(); i++)
                        {

                            if (cuit == ListaEmpresas.GetEmpresa(i).Getcuit())
                            {
                                ListaEmpresas.GetEmpresa(i).MostrarListaEmpleados();
                                senial = 1;
                                Console.WriteLine("\nPresiones una tecla para continuar");
                                Console.ReadLine();
                            }
                        }
                        if (senial == 0)
                        {
                            Console.WriteLine("\nLa empresa no esta registrada");
                            Console.WriteLine("\nPresiones una tecla para continuar");
                            Console.ReadLine();
                        }
                        break;

                    case 9:
                        ListaActividadesAutorizadas.MostrarActividadesAutorizadas();
                        Console.WriteLine("\nPresiones una tecla para continuar");
                        Console.ReadLine();
                        break;

                    case 10:
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
