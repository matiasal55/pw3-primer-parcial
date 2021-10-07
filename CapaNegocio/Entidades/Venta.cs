using System.ComponentModel.DataAnnotations;

namespace CapaNegocio.Entidades
{
    public class Venta
    {
        public int IDVenta { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar el nombre del cliente")]
        [StringLength(maximumLength: 50,ErrorMessage = "El cliente no puede tener más de 50 caracteres")]
        public string Cliente { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar la cantidad vendida")]
        [Range(1,250,ErrorMessage = "La cantidad debe contener un mínimo de 1 unidad y no debe ser más de 250")]
        public int CantidadVendida { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar el precio unitario")]
        [Range(1,999,ErrorMessage = "El precio unitario debe ser como mínimo de $10 y menor a $1000")]
        public int PrecioUnitario { get; set; }

        public double TotalVenta { get; set; }

        public Venta()
        {
        }

        public Venta(string cliente, int cantidadVendida, int precioUnitario)
        {
            Cliente = cliente;
            CantidadVendida = cantidadVendida;
            PrecioUnitario = precioUnitario;
        }
    }
}