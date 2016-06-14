using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Informes_formatos
    {
        public int Codigo { get; set; }
        public int? Informe { get; set; }
        public byte[] Definicion { get; set; }

        public virtual Informes InformeNavigation { get; set; }
    }
}
