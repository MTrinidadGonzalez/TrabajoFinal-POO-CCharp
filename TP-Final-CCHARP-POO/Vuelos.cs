using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public Vuelos(string CodigoVuelo,DateTime FechaHoraSalida,DateTime FechaHoraLlegada, string Piloto, string Copiloto, int CapacidadMaxima, int PasajerosActuales)
        {
            this.CodigoVuelo = CodigoVuelo;
            this.FechaHoraSalida = FechaHoraSalida;
            this.FechaHoraLlegada = FechaHoraLlegada;
            this.Piloto = Piloto;
            this.Copiloto = Copiloto; 
            this.CapacidadMaxima = CapacidadMaxima;
            this.PasajerosActuales = PasajerosActuales;
         }


    }
}
