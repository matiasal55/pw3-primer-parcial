using System.Collections.Generic;
using CapaNegocio.Entidades;

namespace CapaNegocio.Servicios
{
    public class VentasService
    {
        public static List<Venta> ListaDeVentas;

        static VentasService()
        {
            ListaDeVentas = new List<Venta>();
        }

        public void AgregarVenta(Venta venta)
        {
            ListaDeVentas.Add(venta);
        }

        public int ObtenerIDVenta()
        {
            return ListaDeVentas.Count + 1;
        }

        public List<Venta> ListarTodasLasVentas()
        {
            return ListaDeVentas;
        }
    }
}