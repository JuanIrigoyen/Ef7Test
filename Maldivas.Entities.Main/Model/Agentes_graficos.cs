using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Agentes_graficos
    {
        public int Codigo { get; set; }
        public string Agente { get; set; }
        public byte[] Imagen { get; set; }

        public virtual Agentes AgenteNavigation { get; set; }
    }
}
