using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Etiquetas
    {
        public int Codigo { get; set; }
        public string Usuario { get; set; }
        public DateTime? Fecha { get; set; }
        public string Articulo { get; set; }
        public string Articulo_etiqueta { get; set; }
        public int? Numero { get; set; }
        public int? Contador { get; set; }
        public bool Nueva_referencia { get; set; }
        public int Tipo { get; set; }
        public string Interlocutor { get; set; }
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public string Direccion { get; set; }
        public string CPostal { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string Idioma { get; set; }
        public string Referencia { get; set; }
        public string Referencia_original { get; set; }
        public string Referencia_certificada { get; set; }
        public int? Familia_ventas_codigo { get; set; }
        public string Tipo_origen { get; set; }
        public string Sinonimo { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion_idioma { get; set; }
        public string Pais_origen { get; set; }
        public decimal Peso_neto { get; set; }
        public decimal Peso_bruto { get; set; }
        public decimal Volumen_neto { get; set; }
        public decimal Volumen_bruto { get; set; }
        public string Codigo_barras { get; set; }
        public string Ean13 { get; set; }
        public string Pedido { get; set; }
        public string PedidoCliente { get; set; }
        public int? Certificacion_inicial { get; set; }
        public int? Certificacion_final { get; set; }
        public bool Impresion { get; set; }
        public int? Tracking_numero { get; set; }
        public string Tracking { get; set; }
        public string Jaula { get; set; }
        public string Palet { get; set; }
        public string Nif { get; set; }
        public string Operario { get; set; }
        public string Codigo_empresa { get; set; }
        public string Especialidad { get; set; }
        public string Destino { get; set; }
        public string Seccion { get; set; }
        public string Departamento { get; set; }
        public string Observaciones { get; set; }
        public string Grafico { get; set; }
        public int? Orden { get; set; }
        public byte[] Imagen { get; set; }
        public string Ean13b { get; set; }
    }
}
