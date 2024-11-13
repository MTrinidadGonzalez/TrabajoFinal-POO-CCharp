using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace TP_Final_CCHARP_POO
{
    public class Aerolineas
    {
        public string RazonSocial { get; set; }
        public int Telefono { get; set; }
        public string Domicilio { get; set; }
        public List<Vuelos> Vuelos { get; set; } = new List<Vuelos>();

        public Aerolineas(string razonSocial, int telefono, string domicilio)
        {
            RazonSocial = razonSocial;
            Telefono = telefono;
            Domicilio = domicilio;
        }

        public void AgregarVuelo(Vuelos vuelo)
        {
            Vuelos.Add(vuelo);
        }

      public double CalcularOcupacionMedia()
{
    if (Vuelos.Count == 0)
    {
        Console.WriteLine("No hay vuelos registrados aún.");
        return 0;
    }
    else
    {
        double totalOcupacion = 0;
        foreach (var vuelo in Vuelos)
        {
            totalOcupacion += vuelo.CalcularOcupacion();
        }
        return totalOcupacion / Vuelos.Count;
    }
}

public Vuelos VueloConMayorOcupacion()
{
    if (Vuelos.Count == 0)
    {
        Console.WriteLine("No hay vuelos registrados aún.");
        return null;
    }
    else
    {
        Vuelos vueloConMayorOcupacion = null;
        double mayorOcupacion = 0;

        foreach (var vuelo in Vuelos)
        {
            double ocupacionActual = vuelo.CalcularOcupacion();
            if (vueloConMayorOcupacion == null || ocupacionActual > mayorOcupacion)
            {
                vueloConMayorOcupacion = vuelo;
                mayorOcupacion = ocupacionActual;
            }
        }

        return vueloConMayorOcupacion;
    }
}

public Vuelos BuscarVueloPorCodigo(string codigo)
{
    if (Vuelos.Count == 0)
    {
        Console.WriteLine("No hay vuelos registrados aún.");
        return null;
    }
    else
    {
        foreach (var vuelo in Vuelos)
        {
            if (vuelo.CodigoVuelo == codigo)
            {
                return vuelo;
            }
        }
        return null;
    }
}

public List<Vuelos> ListarVuelosOrdenadosPorOcupacion()
{
    if (Vuelos.Count == 0)
    {
        Console.WriteLine("No hay vuelos registrados aún.");
        return new List<Vuelos>();
    }
    else
    {
        List<Vuelos> vuelosOrdenados = new List<Vuelos>(Vuelos);
        vuelosOrdenados.Sort((v1, v2) => v2.CalcularOcupacion().CompareTo(v1.CalcularOcupacion()));
        return vuelosOrdenados;
    }
}

        public void GuardarDatosXML(string archivo)
        {
            var doc = new XDocument(
                new XElement("Vuelos",
                    Vuelos.Select(v => new XElement("Vuelo",
                        new XElement("CodigoVuelo", v.CodigoVuelo),
                        new XElement("FechaHoraSalida", v.FechaHoraSalida),
                        new XElement("FechaHoraLlegada", v.FechaHoraLlegada),
                        new XElement("Piloto", v.Piloto),
                        new XElement("Copiloto", v.Copiloto),
                        new XElement("CapacidadMaxima", v.CapacidadMaxima),
                        new XElement("PasajerosActuales", v.PasajerosActuales)
                    ))
                )
            );
            doc.Save(archivo);
        }

        public static List<Vuelos> CargarDatosXML(string archivo)
        {
            if (System.IO.File.Exists(archivo))
            {
                var doc = XDocument.Load(archivo);
                return doc.Root.Elements("Vuelo").Select(v => new Vuelos(
                    v.Element("CodigoVuelo").Value,
                    DateTime.Parse(v.Element("FechaHoraSalida").Value),
                    DateTime.Parse(v.Element("FechaHoraLlegada").Value),
                    v.Element("Piloto").Value,
                    v.Element("Copiloto").Value,
                    int.Parse(v.Element("CapacidadMaxima").Value),
                    int.Parse(v.Element("PasajerosActuales").Value),
                    new List<Pasajeros>()
                )).ToList();
            }
            return new List<Vuelos>();
        }
    }
}
