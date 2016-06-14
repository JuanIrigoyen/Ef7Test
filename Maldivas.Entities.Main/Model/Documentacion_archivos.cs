using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Documentacion_archivos
    {
        public Guid Id { get; set; }
        public int SystemNumber { get; set; }
        public byte[] SystemFile { get; set; }
    }
}
