﻿using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Personal_turnos
    {
        public Personal_turnos()
        {
            Personal = new HashSet<Personal>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Descripcion { get; set; }
        public string Abreviatura { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Personal> Personal { get; set; }
    }
}
