using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes
    {
        public Clientes()
        {
            //Agencias_transporte_costes_envios = new HashSet<Agencias_transporte_costes_envios>();
            //Clientes_anticipos = new HashSet<Clientes_anticipos>();
            //Clientes_articulos_certificados = new HashSet<Clientes_articulos_certificados>();
            //Clientes_bancos = new HashSet<Clientes_bancos>();
            //Clientes_cuentas_contables = new HashSet<Clientes_cuentas_contables>();
            //Clientes_departamentos = new HashSet<Clientes_departamentos>();
            //Clientes_direcciones = new HashSet<Clientes_direcciones>();
            //Clientes_embalajes_configuracion = new HashSet<Clientes_embalajes_configuracion>();
            //Clientes_graficos = new HashSet<Clientes_graficos>();
            //Clientes_internet_accesos = new HashSet<Clientes_internet_accesos>();
            //Clientes_internet_seguridad_claves = new HashSet<Clientes_internet_seguridad_claves>();
            //Clientes_objetivos = new HashSet<Clientes_objetivos>();
            //Clientes_precios_especiales = new HashSet<Clientes_precios_especiales>();
            //Clientes_precios_especiales_cantidad = new HashSet<Clientes_precios_especiales_cantidad>();
            //Clientes_precios_especiales_cantidad_copia = new HashSet<Clientes_precios_especiales_cantidad_copia>();
            //Clientes_precios_especiales_cantidad_historico = new HashSet<Clientes_precios_especiales_cantidad_historico>();
            //Clientes_precios_especiales_cantidad_temporal = new HashSet<Clientes_precios_especiales_cantidad_temporal>();
            //Clientes_precios_especiales_copia = new HashSet<Clientes_precios_especiales_copia>();
            //Clientes_precios_especiales_historico = new HashSet<Clientes_precios_especiales_historico>();
            //Clientes_precios_especiales_temporal = new HashSet<Clientes_precios_especiales_temporal>();
            //Clientes_procesos = new HashSet<Clientes_procesos>();
            //Clientes_rappels = new HashSet<Clientes_rappels>();
            //Clientes_sinonimos = new HashSet<Clientes_sinonimos>();
            //Clientes_visitas = new HashSet<Clientes_visitas>();
            //Competidores_ofertas = new HashSet<Competidores_ofertas>();
            //Jaulas_movimientos = new HashSet<Jaulas_movimientos>();
            //Jaulas_stocks = new HashSet<Jaulas_stocks>();
            //Preparacion_previa_material_unidades = new HashSet<Preparacion_previa_material_unidades>();
            //Preparacion_previa_material_volumen = new HashSet<Preparacion_previa_material_volumen>();
            //Ventas_albaranes_cabecera = new HashSet<Ventas_albaranes_cabecera>();
            //Ventas_facturas_cabecera = new HashSet<Ventas_facturas_cabecera>();
            //Ventas_pedidos_cabecera = new HashSet<Ventas_pedidos_cabecera>();
            //Ventas_proformas_cabecera = new HashSet<Ventas_proformas_cabecera>();
            //Ventas_reclamaciones_cabecera = new HashSet<Ventas_reclamaciones_cabecera>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public int Numero { get; set; }
        public string Referencia { get; set; }
        public string Referencia_canarias { get; set; }
        public string Nif { get; set; }
        public string Tipo_registro { get; set; }
        public string Tipo_venta { get; set; }
        public short Tipo_operacion { get; set; }
        public bool Exportacion { get; set; }
        public bool Potencial { get; set; }
        public DateTime? Fecha_alta { get; set; }
        public int? Codigo_direccion { get; set; }
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
        public string Clave3 { get; set; }
        public string Horario_oficina1 { get; set; }
        public string Horario_oficina2 { get; set; }
        public string Horario_descarga1 { get; set; }
        public string Horario_descarga2 { get; set; }
        public string Vacaciones_inicio { get; set; }
        public string Vacaciones_final { get; set; }
        public byte[] Imagen { get; set; }
        public string Grafico { get; set; }
        public string Transportista1 { get; set; }
        public string Transportista2 { get; set; }
        public string Agente { get; set; }
        public string Incoterm1 { get; set; }
        public string Incoterm2 { get; set; }
        public string Agente_aduanas_1 { get; set; }
        public string Agente_aduanas_2 { get; set; }
        public string Grupo_sinonimos { get; set; }
        public bool Bloqueo_operaciones { get; set; }
        public bool Bloqueo_informacion { get; set; }
        public string Agencia1 { get; set; }
        public string Agencia2 { get; set; }
        public byte Portes_tipo { get; set; }
        public decimal Portes_recargo_porcentaje { get; set; }
        public decimal Portes_recargo_total { get; set; }
        public decimal Portes_descuento_porcentaje { get; set; }
        public decimal Portes_descuento_total { get; set; }
        public string Portes_trayecto { get; set; }
        public decimal Portes_trayecto_coste { get; set; }
        public string Ruta { get; set; }
        public decimal Recargo_factura { get; set; }
        public decimal Recargo_financiero { get; set; }
        public decimal Descuento_pronto_pago { get; set; }
        public decimal Descuento_volumen { get; set; }
        public decimal Descuento_factura { get; set; }
        public decimal Descuento_linea_detalle { get; set; }
        public decimal Recargo_total1 { get; set; }
        public decimal Recargo_total2 { get; set; }
        public decimal Retencion { get; set; }
        public decimal Comision { get; set; }
        public decimal Riesgo { get; set; }
        public byte Accion_ruptura_riesgo { get; set; }
        public decimal Riesgo_actual { get; set; }
        public byte Agente_tipo { get; set; }
        public string Iva { get; set; }
        public decimal Facturacion { get; set; }
        public bool Restos { get; set; }
        public decimal Factor_impresion { get; set; }
        public string Forma_pago { get; set; }
        public byte Carencia { get; set; }
        public byte Dia_1_pago { get; set; }
        public byte Dia_2_pago { get; set; }
        public byte Dia_3_pago { get; set; }
        public byte Tipo_recibo { get; set; }
        public bool Ajuste_vencimientos { get; set; }
        public byte Decimales_precios { get; set; }
        public byte Decimales_totales { get; set; }
        public byte Decimales_cantidad { get; set; }
        public string Tipo_albaran { get; set; }
        public string Tipo_factura { get; set; }
        public string Serie { get; set; }
        public int Tarifa { get; set; }
        public string Rappel_tipo { get; set; }
        public string Rappel_grupo { get; set; }
        public string Grupo_tarifa { get; set; }
        public string Grupo_compras { get; set; }
        public string Codigo_credito_caucion { get; set; }
        public decimal Riesgo_credito_caucion { get; set; }
        public bool Experimentales { get; set; }
        public bool Intrastat { get; set; }
        public string Divisa { get; set; }
        public string Idioma { get; set; }
        public string Facturacion_cliente { get; set; }
        public string Documentacion { get; set; }
        public bool Documentacion_enviar { get; set; }
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

        public virtual ICollection<Agencias_transporte_costes_envios> Agencias_transporte_costes_envios { get; set; }
        public virtual ICollection<Clientes_anticipos> Clientes_anticipos { get; set; }
        public virtual ICollection<Clientes_articulos_certificados> Clientes_articulos_certificados { get; set; }
        public virtual ICollection<Clientes_bancos> Clientes_bancos { get; set; }
        public virtual ICollection<Clientes_cuentas_contables> Clientes_cuentas_contables { get; set; }
        public virtual ICollection<Clientes_departamentos> Clientes_departamentos { get; set; }
        public virtual ICollection<Clientes_direcciones> Clientes_direcciones { get; set; }
        public virtual ICollection<Clientes_embalajes_configuracion> Clientes_embalajes_configuracion { get; set; }
        public virtual ICollection<Clientes_graficos> Clientes_graficos { get; set; }
        public virtual ICollection<Clientes_internet_accesos> Clientes_internet_accesos { get; set; }
        public virtual ICollection<Clientes_internet_seguridad_claves> Clientes_internet_seguridad_claves { get; set; }
        public virtual ICollection<Clientes_objetivos> Clientes_objetivos { get; set; }
        public virtual ICollection<Clientes_precios_especiales> Clientes_precios_especiales { get; set; }
        public virtual ICollection<Clientes_precios_especiales_cantidad> Clientes_precios_especiales_cantidad { get; set; }
        public virtual ICollection<Clientes_precios_especiales_cantidad_copia> Clientes_precios_especiales_cantidad_copia { get; set; }
        public virtual ICollection<Clientes_precios_especiales_cantidad_historico> Clientes_precios_especiales_cantidad_historico { get; set; }
        public virtual ICollection<Clientes_precios_especiales_cantidad_temporal> Clientes_precios_especiales_cantidad_temporal { get; set; }
        public virtual ICollection<Clientes_precios_especiales_copia> Clientes_precios_especiales_copia { get; set; }
        public virtual ICollection<Clientes_precios_especiales_historico> Clientes_precios_especiales_historico { get; set; }
        public virtual ICollection<Clientes_precios_especiales_temporal> Clientes_precios_especiales_temporal { get; set; }
        public virtual ICollection<Clientes_procesos> Clientes_procesos { get; set; }
        public virtual ICollection<Clientes_rappels> Clientes_rappels { get; set; }
        public virtual ICollection<Clientes_sinonimos> Clientes_sinonimos { get; set; }
        public virtual ICollection<Clientes_visitas> Clientes_visitas { get; set; }
        public virtual ICollection<Competidores_ofertas> Competidores_ofertas { get; set; }
        public virtual ICollection<Jaulas_movimientos> Jaulas_movimientos { get; set; }
        public virtual ICollection<Jaulas_stocks> Jaulas_stocks { get; set; }
        public virtual ICollection<Preparacion_previa_material_unidades> Preparacion_previa_material_unidades { get; set; }
        public virtual ICollection<Preparacion_previa_material_volumen> Preparacion_previa_material_volumen { get; set; }
        public virtual ICollection<Ventas_albaranes_cabecera> Ventas_albaranes_cabecera { get; set; }
        public virtual ICollection<Ventas_facturas_cabecera> Ventas_facturas_cabecera { get; set; }
        public virtual ICollection<Ventas_pedidos_cabecera> Ventas_pedidos_cabecera { get; set; }
        public virtual ICollection<Ventas_proformas_cabecera> Ventas_proformas_cabecera { get; set; }
        public virtual ICollection<Ventas_reclamaciones_cabecera> Ventas_reclamaciones_cabecera { get; set; }
        public virtual Documentacion DocumentacionNavigation { get; set; }
        public virtual Clientes_grupos_compras Grupo_comprasNavigation { get; set; }
        public virtual Articulos_tarifas_tipos TarifaNavigation { get; set; }
    }
}
