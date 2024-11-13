using System;

namespace TP_Final_CCHARP_POO
{
    public class Pasajeros
    {
        public string NombrePasajero { get; set; }
        public string ApellidoPasajero { get; set; }
        public int TelefonoPasajero { get; set; }
        public int DNIPasajero { get; set; }
        public string EmailPasajero { get; set; }

        public Pasajeros(string nombrePasajero, string apellidoPasajero, int telefonoPasajero, int dniPasajero, string emailPasajero)
        {
            NombrePasajero = nombrePasajero;
            ApellidoPasajero = apellidoPasajero;
            TelefonoPasajero = telefonoPasajero;
            DNIPasajero = dniPasajero;
            EmailPasajero = emailPasajero;
        }
    }
}
