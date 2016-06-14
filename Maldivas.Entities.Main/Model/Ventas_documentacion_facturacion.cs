using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ventas_documentacion_facturacion
    {
        public int Factura { get; set; }
        public string Documentacion { get; set; }
        public bool Factura_original { get; set; }
        public bool Factura_copia { get; set; }
        public bool Packing_list { get; set; }
        public bool Certificado_origen_empresa { get; set; }
        public bool Cmr { get; set; }
        public bool Cmr_tonoli { get; set; }
        public bool Cmr_Virgili { get; set; }
        public bool Cmr_Transfin { get; set; }
        public bool Bl { get; set; }
        public bool Bl_enviar_completo { get; set; }
        public bool Bl_enviar_originales { get; set; }
        public bool Eur1 { get; set; }
        public bool Eur1_enviar_empresa { get; set; }
        public bool Eur1_enviar_original { get; set; }
        public bool Eur1_enviar_cliente { get; set; }
        public bool Eur1_entregar { get; set; }
        public string Eur1_entregar_destino { get; set; }
        public bool Ex1 { get; set; }
        public bool Ex1_enviar_empresa { get; set; }
        public bool Ex1_entregar_ejemplar { get; set; }
        public string Ex1_entregar_ejemplar_nombre { get; set; }
        public bool Ex1_enviar_original1 { get; set; }
        public bool Ex1_enviar_original2 { get; set; }
        public bool Ex1_retorno_original { get; set; }
        public bool Ex1_copia_resto { get; set; }
        public bool Ex1_copia_fax { get; set; }
        public bool Certificado_origen { get; set; }
        public bool Certificado_origen_embajada { get; set; }
        public string Certificado_origen_embajada_nombre { get; set; }
        public bool Certificado_origen_camara { get; set; }
        public bool Factura_documento { get; set; }
        public bool Factura_camara { get; set; }
        public bool Factura_embajada { get; set; }
        public string Factura_embajada_nombre { get; set; }
        public bool Seguro { get; set; }
        public bool Seguro_asegurar_mercancia { get; set; }
        public bool Letra { get; set; }
        public bool Letra_entregar_cliente { get; set; }
        public bool Verificada { get; set; }
        public string Observaciones { get; set; }
    }
}
