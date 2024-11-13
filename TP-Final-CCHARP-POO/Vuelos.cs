using System;
using System.Collections.Generic;

namespace TP_Final_CCHARP_POO
{
    public class Vuelos
    {
        public string CodigoVuelo { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public DateTime FechaHoraLlegada { get; set; }
        public string Piloto { get; set; }
        public string Copiloto { get; set; }
        public int CapacidadMaxima { get; set; }
        public int PasajerosActuales { get; set; }
        public List<Pasajeros> ListaPasajeros { get; set; }

        public Vuelos(string codigoVuelo, DateTime fechaHoraSalida, DateTime fechaHoraLlegada, string piloto, string copiloto, int capacidadMaxima, int pasajerosActuales, List<Pasajeros> listaPasajeros)
        {
            CodigoVuelo = codigoVuelo;
            FechaHoraSalida = fechaHoraSalida;
            FechaHoraLlegada = fechaHoraLlegada;
            Piloto = piloto;
            Copiloto = copiloto;
            CapacidadMaxima = capacidadMaxima;
            PasajerosActuales = pasajerosActuales;
            ListaPasajeros = listaPasajeros;
        }

        public double CalcularOcupacion()
        {
            if (CapacidadMaxima == 0)
               
                return 0;
            return (double)PasajerosActuales / CapacidadMaxima * 100;
        }

        public bool AgregarPasajero(Pasajeros pasajero)
        {
            if (PasajerosActuales < CapacidadMaxima)
            {
                ListaPasajeros.Add(pasajero);
                PasajerosActuales++;
                return true;
            }
            return false;
        }
    }
}

/*

namespace TP_Final_CCHARP_POO
{
     public class Vuelos
    {
        public string CodigoVuelo { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public DateTime FechaHoraLlegada { get; set; }
        public string Piloto { get; set; }
        public string Copiloto { get; set; }
        public int CapacidadMaxima { get; set; }
        public int PasajerosActuales { get; set; }
        

        public Vuelos(string codigoVuelo, DateTime fechaHoraSalida, DateTime fechaHoraLlegada, string piloto, string copiloto, int capacidadMaxima, int pasajerosActuales)
        {
            CodigoVuelo = codigoVuelo;
            FechaHoraSalida = fechaHoraSalida;
            FechaHoraLlegada = fechaHoraLlegada;
            Piloto = piloto;
            Copiloto = copiloto;
            CapacidadMaxima = capacidadMaxima;
            PasajerosActuales = pasajerosActuales;
            
        }

        public double CalcularOcupacion() => (double)PasajerosActuales / CapacidadMaxima * 100;

        public bool AgregarPasajeros(int pasajeros)
        {
            if (PasajerosActuales + pasajeros <= CapacidadMaxima)
            {
                PasajerosActuales += pasajeros;
                return true;
            }
            return false;
        }
    }
}


   
*/
