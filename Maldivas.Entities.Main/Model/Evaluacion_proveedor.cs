using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Evaluacion_proveedor
    {
        public string Proveedor { get; set; }
        public int Albaranes_documentacion { get; set; }
        public int Albaranes_informatizados { get; set; }
        public int Albaranes_manuales { get; set; }
        public int Albaranes_datos_erroneos { get; set; }
        public int Indice_documentacion { get; set; }
        public int Albaranes_embalaje { get; set; }
        public int Albaranes_metalico_retornable { get; set; }
        public int Albaranes_madera_retornable { get; set; }
        public int Albaranes_madera_carton_no_retornable { get; set; }
        public int Indice_embalaje { get; set; }
        public int Cantidad_pedidas { get; set; }
        public int Cantidad_servidas { get; set; }
        public int Indice_pendientes { get; set; }
        public int Cantidad_pedidos { get; set; }
        public int Indices_plaza_entrega { get; set; }
        public int Unidades_reclamadas { get; set; }
        public int Unidades_enviadas { get; set; }
        public int Indice_defectuosidad { get; set; }
        public int Valoracion_proveedor { get; set; }
        public string Tipo { get; set; }
    }
}
