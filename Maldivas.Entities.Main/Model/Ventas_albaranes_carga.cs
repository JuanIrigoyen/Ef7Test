using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ventas_albaranes_carga
    {
        public int Codigo { get; set; }
        public DateTime? Fecha_entrada { get; set; }
        public DateTime? Fecha_salida { get; set; }
        public int Albaran { get; set; }
        public int Albaran_numero_linea { get; set; }
        public string Jaula { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public string Almacen { get; set; }
        public string Ubicacion { get; set; }
        public short Orden { get; set; }
        public string Medida { get; set; }
        public string Matricula { get; set; }
        public string Contenedor { get; set; }
        public string Precinto { get; set; }
        public string Introduccion { get; set; }
        public string Repeticion { get; set; }
        public string Completar { get; set; }
        public bool Destino { get; set; }
        public short Orden_carga { get; set; }
        public int Orden_salida { get; set; }
        public bool Procesada { get; set; }
        public bool Reservado { get; set; }

        public virtual Ventas_albaranes_cabecera AlbaranNavigation { get; set; }
        public virtual Ventas_albaranes_detalle Albaran_numero_lineaNavigation { get; set; }
        public virtual Articulos ArticuloNavigation { get; set; }
    }
}
