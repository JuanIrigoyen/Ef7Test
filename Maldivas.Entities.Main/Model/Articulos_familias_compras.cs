using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_familias_compras
    {
        public int Codigo { get; set; }
        public string Familia { get; set; }
        public string Nivel { get; set; }
        public string Descripcion { get; set; }
        public byte[] Imagen { get; set; }
        public string Grafico { get; set; }
        public string Observaciones { get; set; }
    }
}
