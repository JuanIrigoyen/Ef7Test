using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_chapa_calidad
    {
        public Articulos_chapa_calidad()
        {
            Articulos = new HashSet<Articulos>();
            Articulos_lotes = new HashSet<Articulos_lotes>();
            Compras_albaranes_detalle = new HashSet<Compras_albaranes_detalle>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Norma { get; set; }
        public string Embuticion { get; set; }
        public int Limite_elastico_re { get; set; }
        public string Recubrimiento { get; set; }
        public string Aspecto { get; set; }
        public string Acabado { get; set; }
        public string Tratamiento { get; set; }
        public decimal Densidad { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos> Articulos { get; set; }
        public virtual ICollection<Articulos_lotes> Articulos_lotes { get; set; }
        public virtual ICollection<Compras_albaranes_detalle> Compras_albaranes_detalle { get; set; }
        public virtual Articulos_chapa_acabado AcabadoNavigation { get; set; }
        public virtual Articulos_chapa_aspecto AspectoNavigation { get; set; }
        public virtual Articulos_chapa_embuticion EmbuticionNavigation { get; set; }
        public virtual Normas NormaNavigation { get; set; }
        public virtual Articulos_chapa_recubrimiento RecubrimientoNavigation { get; set; }
        public virtual Articulos_chapa_tratamiento TratamientoNavigation { get; set; }
    }
}
