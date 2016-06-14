using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Calendarios_configuracion
    {
        public int Calendario { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }

        public virtual Calendarios CalendarioNavigation { get; set; }
        public virtual Calendarios_tipos TipoNavigation { get; set; }
    }
}
