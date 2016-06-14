using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_utiles
    {
        public string Codigo { get; set; }
        public string Funcion { get; set; }
        public string Componente { get; set; }
        public string Pieza { get; set; }
        public string Mano { get; set; }
        public short? Puestos { get; set; }
        public short? Fase { get; set; }
        public string Marca_vehiculo { get; set; }
        public string Modelo_vehiculo { get; set; }
        public int Largo { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }
        public int Peso_base_inferior { get; set; }
        public int Peso_base_superior { get; set; }
        public decimal Peso { get; set; }
        public string Color { get; set; }
        public string Almacen { get; set; }
        public string Ubicacion { get; set; }
        public string Zona { get; set; }
        public DateTime? Fecha_edicion { get; set; }
        public string Origen { get; set; }
        public string Propiedad { get; set; }
        public string Estado { get; set; }
        public string Orden_trabajo { get; set; }
        public bool Activo { get; set; }
        public string Observaciones { get; set; }
    }
}
