using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Scheduler_destinatarios
    {
        public int Codigo { get; set; }
        public int? Scheduler { get; set; }
        public string Email { get; set; }

        public virtual Scheduler_configuracion SchedulerNavigation { get; set; }
    }
}
