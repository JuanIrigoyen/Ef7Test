using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Formacion_ficheros
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Fichero { get; set; }
        public string Direccion_web { get; set; }
        public string Observaciones { get; set; }
    }
}
