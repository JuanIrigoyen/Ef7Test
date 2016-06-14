using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_consumos
    {
        public int Codigo { get; set; }
        public string Articulo_imputado { get; set; }
        public string Articulo { get; set; }
        public string Troquel { get; set; }
        public string Maquina { get; set; }
        public string Centro { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public string Departamento { get; set; }
        public string Almacen { get; set; }
        public string Ubicacion { get; set; }
        public string Usuario { get; set; }
    }
}
