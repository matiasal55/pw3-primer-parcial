using System.Collections.Generic;
using CapaNegocio.Entidades;
using CapaNegocio.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace RegistroDeVentas.Controllers
{
    public class VentasController : Controller
    {
        private VentasService service;

        public VentasController()
        {
            service = new VentasService();
        }
        
        public IActionResult RegistrarVenta()
        {
            return View();
        }

        public IActionResult Resultados()
        {
            List<Venta> ListaDeVentas = service.ListarTodasLasVentas();
            ViewBag.ListaDeventas = ListaDeVentas;
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarVenta(Venta venta)
        {
            int CantidadVendida = venta.CantidadVendida;
            int PrecioUnitario = venta.PrecioUnitario;
            int TotalSinIva = CantidadVendida * PrecioUnitario;
            venta.TotalVenta = TotalSinIva * 1.21;
            venta.IDVenta = service.ObtenerIDVenta();
            service.AgregarVenta(venta);
            return RedirectToAction(nameof(Resultados));
        }
    }
}