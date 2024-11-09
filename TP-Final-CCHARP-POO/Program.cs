
//cd C:/Users/Usuario/source/repos/TP-Final-CCHARP-POO

using System;

//sing TP_Final_CCHARP_POO

 //pruebo usar la clase
 //Vuelos vuelo = new Vuelos("RF100","Pedro Ramirez","Estaban Saz",60,25);


namespace TP_Final_CCHARP_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Vuelo> vuelos = CargarDatosXML("vuelos.xml");
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Agregar un vuelo");
                Console.WriteLine("2. Registrar pasajeros");
                Console.WriteLine("3. Calcular ocupación media");
                Console.WriteLine("4. Ver vuelo con mayor ocupación");
                Console.WriteLine("5. Buscar vuelo por código");
                Console.WriteLine("6. Listar vuelos por ocupación");
                Console.WriteLine("7. Guardar y salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                case 1 : 
                        Console.WriteLine("Opción 1");
                //AgregarVuelo(vuelos);
                break;
                case 2 : 
                        Console.WriteLine("Opción 2");
                //RegistrarPasajeros(vuelos);
                break;
                case 3 : 
                        Console.WriteLine("Opción 3");
                //CalcularOcupacionMedia(vuelos);
                break;
                case 4 : 
                        Console.WriteLine("Opción 4");
                //VueloConMayorOcupacion(vuelos);
                break;
                case 5 : 
                        Console.WriteLine("Opción 5");
                //BuscarVueloPorCodigo(vuelos);
                break;
                case 6 : 
                        Console.WriteLine("Opción 6");
                //ListarVuelosOrdenados(vuelos);
                break;
                case 7 : 
                        Console.WriteLine("Opción 7");
                //GuardarDatosXML(vuelos, "vuelos.xml");
                continuar = false;
                break;
            default:
                Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                break;
            
                }//cierre del switch
            }//cierre del while


            
           

        }//fin del static void main
    }//fin de class program
}//final namespace