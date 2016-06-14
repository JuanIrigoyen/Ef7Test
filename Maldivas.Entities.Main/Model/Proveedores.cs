using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Proveedores
    {
        public Proveedores()
        {
            Articulos = new HashSet<Articulos>();
            Articulos_lotes = new HashSet<Articulos_lotes>();
            Cartera_compras = new HashSet<Cartera_compras>();
            Compras_albaranes_cabecera = new HashSet<Compras_albaranes_cabecera>();
            Compras_pedidos_cabecera = new HashSet<Compras_pedidos_cabecera>();
            Compras_proformas_cabecera = new HashSet<Compras_proformas_cabecera>();
            Proveedores_bancos = new HashSet<Proveedores_bancos>();
            Proveedores_certificaciones = new HashSet<Proveedores_certificaciones>();
            Proveedores_graficos = new HashSet<Proveedores_graficos>();
            Proveedores_precios_compra = new HashSet<Proveedores_precios_compra>();
            Proveedores_presupuestos_prevision = new HashSet<Proveedores_presupuestos_prevision>();
            Troqueles_empresas = new HashSet<Troqueles_empresas>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public int Numero { get; set; }
        public string Nif { get; set; }
        public int? Codigo_direccion { get; set; }
        public string Referencia { get; set; }
        public DateTime? Fecha_alta { get; set; }
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Comunidad { get; set; }
        public string Pais { get; set; }
        public string Cpais { get; set; }
        public string Cpostal { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Telefono3 { get; set; }
        public string Movil1 { get; set; }
        public string Movil2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Voip1 { get; set; }
        public string Voip2 { get; set; }
        public string Zona { get; set; }
        public string Internet { get; set; }
        public string Ftp { get; set; }
        public string Usuario { get; set; }
        public string Clave1 { get; set; }
        public string Clave2 { get; set; }
        public string Horario_oficina1 { get; set; }
        public string Horario_oficina2 { get; set; }
        public string Horario_descarga1 { get; set; }
        public string Horario_descarga2 { get; set; }
        public string Vacaciones_inicio { get; set; }
        public string Vacaciones_final { get; set; }
        public byte[] Imagen { get; set; }
        public string Grafico { get; set; }
        public string Agente { get; set; }
        public byte Agente_tipo { get; set; }
        public string Incoterm1 { get; set; }
        public string Incoterm2 { get; set; }
        public string Agente_aduanas_1 { get; set; }
        public string Agente_aduanas_2 { get; set; }
        public string Grupo_sinonimos { get; set; }
        public int Plazo_entrega { get; set; }
        public bool Bloqueo_operaciones { get; set; }
        public bool Bloqueo_informacion { get; set; }
        public bool Autofacturacion { get; set; }
        public bool AutofacturacionConfiguracion { get; set; }
        public string Iva { get; set; }
        public string Departamento { get; set; }
        public byte Portes_tipo { get; set; }
        public decimal Portes_recargo_porcentaje { get; set; }
        public decimal Portes_descuento_porcentaje { get; set; }
        public decimal Portes_recargo_total { get; set; }
        public decimal Portes_descuento_total { get; set; }
        public decimal Recargo_factura { get; set; }
        public decimal Recargo_financiero { get; set; }
        public decimal Descuento_volumen { get; set; }
        public decimal Descuento_factura { get; set; }
        public decimal Descuento_linea_detalle { get; set; }
        public decimal Descuento_pronto_pago { get; set; }
        public decimal Retencion { get; set; }
        public bool Restos { get; set; }
        public decimal Factor { get; set; }
        public string Confirming_tipo { get; set; }
        public bool Confirming_pronto_pago { get; set; }
        public string Forma_pago { get; set; }
        public byte Carencia { get; set; }
        public byte Dia_1_pago { get; set; }
        public byte Dia_2_pago { get; set; }
        public byte Dia_3_pago { get; set; }
        public bool Ajuste_vencimientos { get; set; }
        public byte Tipo_recibo { get; set; }
        public byte Decimales_precios { get; set; }
        public byte Decimales_totales { get; set; }
        public byte Decimales_cantidad { get; set; }
        public string Serie { get; set; }
        public bool Intrastat { get; set; }
        public string Agencia1 { get; set; }
        public string Agencia2 { get; set; }
        public decimal Riesgo { get; set; }
        public byte Accion_ruptura_riesgo { get; set; }
        public decimal Riesgo_actual { get; set; }
        public string Divisa { get; set; }
        public string Idioma { get; set; }
        public int Lead_time { get; set; }
        public string Observaciones_proformas { get; set; }
        public string Observaciones_pedidos { get; set; }
        public string Observaciones_albaranes { get; set; }
        public string Observaciones_facturas { get; set; }
        public string Observaciones_generales { get; set; }
        public string Observaciones_privadas { get; set; }
        public string Observaciones_almacen { get; set; }
        public string Observaciones_administracion { get; set; }
        public string Observaciones_embalajes { get; set; }
        public string Observaciones_mailing { get; set; }
        public string Observaciones_internet { get; set; }
        public string Observaciones_promocion { get; set; }
        public string Internet_grupo { get; set; }
        public bool Internet_acceso { get; set; }

        public virtual ICollection<Articulos> Articulos { get; set; }
        public virtual ICollection<Articulos_lotes> Articulos_lotes { get; set; }
        public virtual ICollection<Cartera_compras> Cartera_compras { get; set; }
        public virtual ICollection<Compras_albaranes_cabecera> Compras_albaranes_cabecera { get; set; }
        public virtual ICollection<Compras_pedidos_cabecera> Compras_pedidos_cabecera { get; set; }
        public virtual ICollection<Compras_proformas_cabecera> Compras_proformas_cabecera { get; set; }
        public virtual ICollection<Proveedores_bancos> Proveedores_bancos { get; set; }
        public virtual ICollection<Proveedores_certificaciones> Proveedores_certificaciones { get; set; }
        public virtual ICollection<Proveedores_graficos> Proveedores_graficos { get; set; }
        public virtual ICollection<Proveedores_precios_compra> Proveedores_precios_compra { get; set; }
        public virtual ICollection<Proveedores_presupuestos_prevision> Proveedores_presupuestos_prevision { get; set; }
        public virtual ICollection<Troqueles_empresas> Troqueles_empresas { get; set; }
    }
}
