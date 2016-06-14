using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Vinculos_externos_usuarios
    {
        public string Vinculo { get; set; }
        public string Usuario { get; set; }

        public virtual Vinculos_externos VinculoNavigation { get; set; }
    }
}
