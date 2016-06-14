using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Scheduler_log
    {
        public int Codigo { get; set; }
        public int? Scheduler { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha { get; set; }
        public bool Error { get; set; }
        public string Error_informacion { get; set; }

        public virtual Scheduler_configuracion SchedulerNavigation { get; set; }
    }
}
