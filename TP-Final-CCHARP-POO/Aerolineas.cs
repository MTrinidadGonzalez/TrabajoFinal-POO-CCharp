using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final_CCHARP_POO
{
    internal class Aerolineas
    {
        public string RazonSocial { get; set; }
        public int Telefono { get; set; }
        public string Domicilio { get; set; }
        //public List<Vuelo> Vuelos { get; set; } = new List<Vuelo>();

        public Aerolineas(string RazonSocial,int Telefono,string Domicilio) 
            {
            this.RazonSocial= RazonSocial;  
            this.Telefono= Telefono;    
            this.Domicilio= Domicilio;  
            } 

    }
}
