using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_traducciones
    {
        public int Codigo { get; set; }
        public string Espanol { get; set; }
        public string Idioma { get; set; }
        public string Traduccion { get; set; }
        public string Referencia_auxiliar { get; set; }
        public string Tipo_campo { get; set; }
    }
}
