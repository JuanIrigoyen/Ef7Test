using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Utiles_control
    {
        public string Codigo { get; set; }
        public string Funcion { get; set; }
        public string Componente { get; set; }
        public string Pieza { get; set; }
        public short? Puestos { get; set; }
        public short? Fase { get; set; }
        public string Codigo_barras { get; set; }
        public string Vehiculo { get; set; }
        public decimal Largo { get; set; }
        public decimal Ancho { get; set; }
        public decimal Alto { get; set; }
        public decimal Peso { get; set; }
        public string Color { get; set; }
        public string Ubicacion { get; set; }
        public DateTime? Fecha_edicion { get; set; }
        public string Origen { get; set; }
        public string Propiedad { get; set; }
        public string Estado { get; set; }
        public string Orden_trabajo { get; set; }
        public bool Activo { get; set; }
        public string Grafico { get; set; }
        public byte[] Imagen { get; set; }
        public string Observaciones { get; set; }
    }
}
