using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Scheduler_parameters
    {
        public int Codigo { get; set; }
        public int? Scheduler { get; set; }
        public string Parametro { get; set; }
        public string Valor { get; set; }

        public virtual Scheduler_configuracion SchedulerNavigation { get; set; }
    }
}
