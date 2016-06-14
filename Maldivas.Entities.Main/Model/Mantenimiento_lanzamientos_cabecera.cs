using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Mantenimiento_lanzamientos_cabecera
    {
        public int Iden { get; set; }
        public string Descripcion_gama { get; set; }
        public string Seccion { get; set; }
        public string Equipo_instalacion { get; set; }
        public DateTime? Fecha_lanzamiento { get; set; }
        public string Aplicacion_gama { get; set; }
        public int? Gama { get; set; }
        public DateTime? Fecha_ejecucion { get; set; }
        public string Ejecutado { get; set; }
        public string Observaciones { get; set; }
    }
}
