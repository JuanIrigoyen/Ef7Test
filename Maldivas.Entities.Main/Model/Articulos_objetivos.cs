using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_objetivos
    {
        public string Articulo { get; set; }
        public string Ejercicio { get; set; }
        public decimal? Objetivo_nacional { get; set; }
        public decimal? Objetivo_exportacion { get; set; }
        public decimal? Objetivo_real_nacional { get; set; }
        public decimal? Objetivo_real_exportacion { get; set; }
        public decimal? Objetivo_media_nacional { get; set; }
        public decimal? Objetivo_media_exportacion { get; set; }
        public decimal? Precio_objetivo_nacional { get; set; }
        public decimal? Precio_objetivo_exportacion { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
    }
}
