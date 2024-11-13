using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TP_Final_CCHARP_POO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aerolineas aerolinea = new Aerolineas("Nombre Aerolinea", 123456789, "Domicilio");
            aerolinea.Vuelos = Aerolineas.CargarDatosXML("vuelos.xml"); 

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Agregar un vuelo");
                Console.WriteLine("2. Registrar pasajero en un vuelo");
                Console.WriteLine("3. Calcular ocupación media");
                Console.WriteLine("4. Ver vuelo con mayor ocupación");
                Console.WriteLine("5. Buscar vuelo por código");
                Console.WriteLine("6. Listar vuelos por ocupación");
                Console.WriteLine("7. Guardar y salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el código de vuelo:");
                        string codigoVuelo = Console.ReadLine();
                        Console.WriteLine("Ingrese fecha y hora de salida (ej. 2000-12-11 13:30):");
                        DateTime fechaHoraSalida = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese fecha y hora de llegada (ej. 2000-12-11 15:30):");
                        DateTime fechaHoraLlegada = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el nombre del piloto:");
                        string piloto = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del copiloto:");
                        string copiloto = Console.ReadLine();
                        Console.WriteLine("Ingrese la capacidad máxima de pasajeros:");
                        int capacidadMaxima = int.Parse(Console.ReadLine());

                        if (string.IsNullOrEmpty(codigoVuelo) || fechaHoraSalida == default || fechaHoraLlegada == default || string.IsNullOrEmpty(piloto) || string.IsNullOrEmpty(copiloto))
                        {
                            Console.WriteLine("Todos los datos deben ingresarse de forma válida.");
                        }
                        else
                        {
                            Vuelos vuelo = new Vuelos(codigoVuelo, fechaHoraSalida, fechaHoraLlegada, piloto, copiloto, capacidadMaxima, 0, new List<Pasajeros>());
                            aerolinea.AgregarVuelo(vuelo);
                            Console.WriteLine("Vuelo agregado exitosamente.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el código del vuelo:");
                        string codigoParaPasajeros = Console.ReadLine();

                        Vuelos vueloEncontrado = aerolinea.BuscarVueloPorCodigo(codigoParaPasajeros);
                        if (vueloEncontrado != null)
                        {
                            Console.WriteLine("Ingrese el nombre del pasajero:");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el apellido del pasajero:");
                            string apellido = Console.ReadLine();
                            Console.WriteLine("Ingrese el teléfono del pasajero:");
                            int telefono = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el DNI del pasajero:");
                            int dni = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el email del pasajero:");
                            string email = Console.ReadLine();

                            Pasajeros nuevoPasajero = new Pasajeros(nombre, apellido, telefono, dni, email);

                            if (vueloEncontrado.AgregarPasajero(nuevoPasajero))
                            {
                                Console.WriteLine("Pasajero registrado exitosamente.");
                            }
                            else
                            {
                                Console.WriteLine("No se pueden registrar más pasajeros de la capacidad máxima.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Vuelo no encontrado.");
                        }
                        break;

                    case 3:
                        Console.WriteLine($"Ocupación media de la flota: {aerolinea.CalcularOcupacionMedia():F2}%");
                        break;

                    case 4:
                        var vueloMax = aerolinea.VueloConMayorOcupacion();
                        if (vueloMax != null)
                        {
                            Console.WriteLine($"Vuelo con mayor ocupación: {vueloMax.CodigoVuelo} - Ocupación: {vueloMax.CalcularOcupacion():F2}%");
                        }
                        else
                        {
                            Console.WriteLine("No hay vuelos registrados.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Ingrese el código del vuelo:");
                        string codigoBusqueda = Console.ReadLine();
                        var vueloBuscado = aerolinea.BuscarVueloPorCodigo(codigoBusqueda);
                        if (vueloBuscado != null)
                        {
                            Console.WriteLine($"Código: {vueloBuscado.CodigoVuelo}, Salida: {vueloBuscado.FechaHoraSalida}, Llegada: {vueloBuscado.FechaHoraLlegada}, Ocupación: {vueloBuscado.CalcularOcupacion():F2}%");
                        }
                        else
                        {
                            Console.WriteLine("Vuelo no encontrado.");
                        }
                        break;

                    case 6:
                        var vuelosOrdenados = aerolinea.ListarVuelosOrdenadosPorOcupacion();
                        foreach (var vuelo in vuelosOrdenados)
                        {
                            Console.WriteLine($"Vuelo {vuelo.CodigoVuelo} - Ocupación: {vuelo.CalcularOcupacion():F2}%");
                        }
                        break;

                    case 7:
                        aerolinea.GuardarDatosXML("vuelos.xml");
                        Console.WriteLine("Datos guardados en XML. Finalizando...");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
