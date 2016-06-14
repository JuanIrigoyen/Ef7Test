using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Troqueles_inventario
    {
        public string Troquel { get; set; }
        public string Ubicacion { get; set; }
        public string Origen { get; set; }
        public decimal Precio_costo { get; set; }
        public decimal Valor { get; set; }
        public int Cantidad { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public virtual Troqueles TroquelNavigation { get; set; }
    }
}
