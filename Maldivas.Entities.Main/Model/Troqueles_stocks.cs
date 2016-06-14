using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Troqueles_stocks
    {
        public string Troquel { get; set; }
        public string Almacen { get; set; }
        public string Ubicacion { get; set; }
        public int? Cantidad { get; set; }
        public string Interlocutor { get; set; }

        public virtual Troqueles TroquelNavigation { get; set; }
    }
}
