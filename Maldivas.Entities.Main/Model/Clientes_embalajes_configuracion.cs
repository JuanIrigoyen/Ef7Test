using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_embalajes_configuracion
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public string Tipo_pieza { get; set; }
        public string Articulo { get; set; }
        public string Embalaje { get; set; }
        public string Marca { get; set; }
        public bool Certificada { get; set; }
        public decimal Precio { get; set; }
        public decimal? Precio_porcentaje { get; set; }
        public decimal Altura_palet { get; set; }
        public bool ExtraUE { get; set; }
        public bool Material_frances { get; set; }
        public bool Material_no_frances { get; set; }
        public int? Direccion { get; set; }
        public bool Desactivo { get; set; }

        public virtual Clientes ClienteNavigation { get; set; }
        public virtual Embalajes EmbalajeNavigation { get; set; }
    }
}
