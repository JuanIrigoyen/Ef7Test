using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Etiquetas_rangos
    {
        public Etiquetas_rangos()
        {
            Etiquetas_registro = new HashSet<Etiquetas_registro>();
        }

        public int Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Rango_inicial { get; set; }
        public int Rango_final { get; set; }
        public int Contador { get; set; }
        public bool Notificado { get; set; }

        public virtual ICollection<Etiquetas_registro> Etiquetas_registro { get; set; }
    }
}
