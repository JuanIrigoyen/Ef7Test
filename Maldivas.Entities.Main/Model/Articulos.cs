using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos
    {
        public Articulos()
        {
            Articulos_almacen_ubicacion_predeterminada = new HashSet<Articulos_almacen_ubicacion_predeterminada>();
            Articulos_catalogo_repetidos = new HashSet<Articulos_catalogo_repetidos>();
            Articulos_certificaciones = new HashSet<Articulos_certificaciones>();
            Articulos_clasificacion_relacion = new HashSet<Articulos_clasificacion_relacion>();
            Articulos_competidores_acuerdos = new HashSet<Articulos_competidores_acuerdos>();
            Articulos_conjuntosHijoNavigation = new HashSet<Articulos_conjuntos>();
            Articulos_conjuntosPadreNavigation = new HashSet<Articulos_conjuntos>();
            Articulos_contenedores_capacidad = new HashSet<Articulos_contenedores_capacidad>();
            Articulos_embalajes = new HashSet<Articulos_embalajes>();
            Articulos_etiquetas_idiomas = new HashSet<Articulos_etiquetas_idiomas>();
            Articulos_familias_ventas_multiples = new HashSet<Articulos_familias_ventas_multiples>();
            Articulos_fases = new HashSet<Articulos_fases>();
            Articulos_graficos = new HashSet<Articulos_graficos>();
            Articulos_guia_tasaciones = new HashSet<Articulos_guia_tasaciones>();
            Articulos_idiomas = new HashSet<Articulos_idiomas>();
            Articulos_imagenes = new HashSet<Articulos_imagenes>();
            Articulos_lotes = new HashSet<Articulos_lotes>();
            Articulos_movimientos = new HashSet<Articulos_movimientos>();
            Articulos_objetivos = new HashSet<Articulos_objetivos>();
            Articulos_piecerio_subcontratado = new HashSet<Articulos_piecerio_subcontratado>();
            Articulos_referencias_produccion = new HashSet<Articulos_referencias_produccion>();
            Articulos_reparto_costes = new HashSet<Articulos_reparto_costes>();
            Articulos_stocks = new HashSet<Articulos_stocks>();
            Articulos_stocks_configuracion = new HashSet<Articulos_stocks_configuracion>();
            Articulos_stocks_conjuntos = new HashSet<Articulos_stocks_conjuntos>();
            Articulos_tarifas = new HashSet<Articulos_tarifas>();
            Articulos_tarifas_copia = new HashSet<Articulos_tarifas_copia>();
            Articulos_tarifas_historico = new HashSet<Articulos_tarifas_historico>();
            Articulos_tarifas_temporal = new HashSet<Articulos_tarifas_temporal>();
            Clientes_articulos_bloqueados = new HashSet<Clientes_articulos_bloqueados>();
            Clientes_articulos_certificados = new HashSet<Clientes_articulos_certificados>();
            Clientes_grupos_tarifas = new HashSet<Clientes_grupos_tarifas>();
            Clientes_grupos_tarifas_copia = new HashSet<Clientes_grupos_tarifas_copia>();
            Clientes_grupos_tarifas_historico = new HashSet<Clientes_grupos_tarifas_historico>();
            Clientes_grupos_tarifas_temporal = new HashSet<Clientes_grupos_tarifas_temporal>();
            Clientes_precios_especiales = new HashSet<Clientes_precios_especiales>();
            Clientes_precios_especiales_cantidad = new HashSet<Clientes_precios_especiales_cantidad>();
            Clientes_precios_especiales_cantidad_copia = new HashSet<Clientes_precios_especiales_cantidad_copia>();
            Clientes_precios_especiales_cantidad_historico = new HashSet<Clientes_precios_especiales_cantidad_historico>();
            Clientes_precios_especiales_cantidad_temporal = new HashSet<Clientes_precios_especiales_cantidad_temporal>();
            Clientes_precios_especiales_copia = new HashSet<Clientes_precios_especiales_copia>();
            Clientes_precios_especiales_historico = new HashSet<Clientes_precios_especiales_historico>();
            Clientes_precios_especiales_temporal = new HashSet<Clientes_precios_especiales_temporal>();
            Clientes_sinonimos = new HashSet<Clientes_sinonimos>();
            Competidores_articulos_certificados = new HashSet<Competidores_articulos_certificados>();
            Competidores_ofertas = new HashSet<Competidores_ofertas>();
            Compras_albaranes_detalle = new HashSet<Compras_albaranes_detalle>();
            Compras_facturas_detalle = new HashSet<Compras_facturas_detalle>();
            Compras_pedidos_detalle = new HashSet<Compras_pedidos_detalle>();
            Compras_proformas_detalle = new HashSet<Compras_proformas_detalle>();
            Compras_reclamaciones_detalle = new HashSet<Compras_reclamaciones_detalle>();
            Ordenes_trabajo = new HashSet<Ordenes_trabajo>();
            Preparacion_previa_material_unidades = new HashSet<Preparacion_previa_material_unidades>();
            Preparacion_previa_material_volumen = new HashSet<Preparacion_previa_material_volumen>();
            Proveedores_articulos_bloqueados = new HashSet<Proveedores_articulos_bloqueados>();
            Proveedores_precios_compra = new HashSet<Proveedores_precios_compra>();
            Proveedores_sinonimos = new HashSet<Proveedores_sinonimos>();
            Troqueles_articulos_proveedores = new HashSet<Troqueles_articulos_proveedores>();
            Ventas_albaranes_carga = new HashSet<Ventas_albaranes_carga>();
            Ventas_albaranes_detalle = new HashSet<Ventas_albaranes_detalle>();
            Ventas_facturas_detalle = new HashSet<Ventas_facturas_detalle>();
            Ventas_pedidos_detalle = new HashSet<Ventas_pedidos_detalle>();
            Ventas_proformas_detalle = new HashSet<Ventas_proformas_detalle>();
            Ventas_reclamaciones_detalle = new HashSet<Ventas_reclamaciones_detalle>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Referencia_base { get; set; }
        public string Referencia_auxiliar { get; set; }
        public string Referencia_original { get; set; }
        public string Referencia_fabricación { get; set; }
        public string Referencia_medio_ambiente { get; set; }
        public string Referencia_francesa { get; set; }
        public string Referencia_israelita { get; set; }
        public string Referencia_certificada { get; set; }
        public string Referencia_certificada_thatcham { get; set; }
        public string Referencia_certificada_hs { get; set; }
        public string Referencia_certificada_tuv { get; set; }
        public string Estado { get; set; }
        public bool Catalogo { get; set; }
        public int Catalogo_orden { get; set; }
        public string Numero_serie { get; set; }
        public DateTime? Fecha_creacion { get; set; }
        public DateTime? Fecha_baja { get; set; }
        public byte Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion_tarifa_nacional { get; set; }
        public string Materia_prima { get; set; }
        public DateTime? Novedad_fecha_inicial { get; set; }
        public DateTime? Novedad_fecha_final { get; set; }
        public string Novedad_observaciones { get; set; }
        public short Plazo_aprovisionamiento { get; set; }
        public short Plazo_seguridad { get; set; }
        public string Familia_ventas { get; set; }
        public string Subfamilia_ventas { get; set; }
        public string Familia_medio_ambiente { get; set; }
        public int Ventas_lote { get; set; }
        public int Fabricacion_lote { get; set; }
        public string Familia_compras { get; set; }
        public string Subfamilia_compras { get; set; }
        public int Compras_lote { get; set; }
        public int Unidades { get; set; }
        public string Unidad_medida_compra { get; set; }
        public string Unidad_medida_venta { get; set; }
        public string Unidad_medida_almacen { get; set; }
        public int Unidad_caja { get; set; }
        public int Jaulas { get; set; }
        public int Stock_minimo { get; set; }
        public int Stock_seguridad { get; set; }
        public bool Control_stocks { get; set; }
        public bool Descripcion_fija { get; set; }
        public bool Excluir { get; set; }
        public bool Descriptivo { get; set; }
        public bool Laser { get; set; }
        public bool Compras { get; set; }
        public bool Ventas { get; set; }
        public string Proveedor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Version { get; set; }
        public string Mano { get; set; }
        public string Medida { get; set; }
        public string Almacen_ventas { get; set; }
        public string Almacen_compras { get; set; }
        public string Almacen_compras_ubicacion { get; set; }
        public string Almacen_ventas_ubicacion { get; set; }
        public DateTime? Fecha_alta { get; set; }
        public decimal Peso_neto { get; set; }
        public decimal Peso_bruto { get; set; }
        public decimal Volumen_neto { get; set; }
        public decimal Volumen_bruto { get; set; }
        public decimal Precio_costo { get; set; }
        public decimal Precio_ultimo_costo { get; set; }
        public decimal Precio_certificada { get; set; }
        public decimal Precio_ultima_compra { get; set; }
        public decimal Precio_medio { get; set; }
        public double Medidas_alto { get; set; }
        public decimal Medidas_largo { get; set; }
        public decimal Medidas_largo_c { get; set; }
        public decimal Medidas_ancho { get; set; }
        public decimal Medidas_espesor { get; set; }
        public double Medidas_diagonal { get; set; }
        public double Medidas_base_inferior { get; set; }
        public double Medidas_base_superior { get; set; }
        public double Medidas_altura_1 { get; set; }
        public double Medidas_altura_2 { get; set; }
        public decimal Medidas_radio { get; set; }
        public decimal Medidas_paso { get; set; }
        public int Piezas_por_formato { get; set; }
        public string Chapa_calidad { get; set; }
        public string Chapa_forma { get; set; }
        public string Chapa_medida { get; set; }
        public int Unidades_reservadas { get; set; }
        public int Unidades_ordenadas { get; set; }
        public short Plazo_garantia { get; set; }
        public string Iva { get; set; }
        public string Iva_contabilidad { get; set; }
        public bool Oferta { get; set; }
        public int Existencias { get; set; }
        public string Tipo_origen { get; set; }
        public string Tipo_competencia { get; set; }
        public string Tipo_calidad { get; set; }
        public string Tipo_troqueles { get; set; }
        public string Tipo_acabado { get; set; }
        public string Tipo_montaje { get; set; }
        public string Tipo_producto { get; set; }
        public string Tipo_estado { get; set; }
        public string Tipo_produccion { get; set; }
        public string Tipo_suministro { get; set; }
        public int Serie_minima_rentable { get; set; }
        public string Complejidad { get; set; }
        public short Imagen_estructura { get; set; }
        public bool Actualizacion_diferida_lote { get; set; }
        public bool Tipo_informatica { get; set; }
        public bool Tipo_oficina { get; set; }
        public bool Tipo_logistica { get; set; }
        public bool Tipo_cataforesis { get; set; }
        public bool Tipo_mantenimiento { get; set; }
        public bool Tipo_matriceria { get; set; }
        public bool Tipo_gestion { get; set; }
        public bool Tipo_carroceria { get; set; }
        public string Ean8 { get; set; }
        public string Ean13 { get; set; }
        public string Ean39 { get; set; }
        public string Ean128a { get; set; }
        public string Ean128b { get; set; }
        public string Ean128c { get; set; }
        public decimal Precio_costo_fabricacion { get; set; }
        public decimal Precio_inversion { get; set; }
        public int Punto_muerto_piezas_iniciales { get; set; }
        public int Punto_muerto_piezas_actuales { get; set; }
        public decimal Precio_venta_publico_base { get; set; }
        public string Fabricante { get; set; }
        public bool Base { get; set; }
        public bool Calculo_totales_peso { get; set; }
        public bool Fin_produccion { get; set; }
        public string Plancha { get; set; }
        public string Cuenta_contable { get; set; }
        public string Contenedor_tipo { get; set; }
        public int Lead_time { get; set; }
        public bool Lanzamiento_supermercado { get; set; }
        public string Observaciones { get; set; }
        public string Ean13b { get; set; }

        public virtual ICollection<Articulos_almacen_ubicacion_predeterminada> Articulos_almacen_ubicacion_predeterminada { get; set; }
        public virtual Articulos_calculo_punto_pedido Articulos_calculo_punto_pedido { get; set; }
        public virtual ICollection<Articulos_catalogo_repetidos> Articulos_catalogo_repetidos { get; set; }
        public virtual ICollection<Articulos_certificaciones> Articulos_certificaciones { get; set; }
        public virtual ICollection<Articulos_clasificacion_relacion> Articulos_clasificacion_relacion { get; set; }
        public virtual ICollection<Articulos_competidores_acuerdos> Articulos_competidores_acuerdos { get; set; }
        public virtual ICollection<Articulos_conjuntos> Articulos_conjuntosHijoNavigation { get; set; }
        public virtual ICollection<Articulos_conjuntos> Articulos_conjuntosPadreNavigation { get; set; }
        public virtual ICollection<Articulos_contenedores_capacidad> Articulos_contenedores_capacidad { get; set; }
        public virtual ICollection<Articulos_embalajes> Articulos_embalajes { get; set; }
        public virtual ICollection<Articulos_etiquetas_idiomas> Articulos_etiquetas_idiomas { get; set; }
        public virtual ICollection<Articulos_familias_ventas_multiples> Articulos_familias_ventas_multiples { get; set; }
        public virtual ICollection<Articulos_fases> Articulos_fases { get; set; }
        public virtual ICollection<Articulos_graficos> Articulos_graficos { get; set; }
        public virtual ICollection<Articulos_guia_tasaciones> Articulos_guia_tasaciones { get; set; }
        public virtual ICollection<Articulos_idiomas> Articulos_idiomas { get; set; }
        public virtual ICollection<Articulos_imagenes> Articulos_imagenes { get; set; }
        public virtual ICollection<Articulos_lotes> Articulos_lotes { get; set; }
        public virtual ICollection<Articulos_movimientos> Articulos_movimientos { get; set; }
        public virtual ICollection<Articulos_objetivos> Articulos_objetivos { get; set; }
        public virtual ICollection<Articulos_piecerio_subcontratado> Articulos_piecerio_subcontratado { get; set; }
        public virtual ICollection<Articulos_referencias_produccion> Articulos_referencias_produccion { get; set; }
        public virtual ICollection<Articulos_reparto_costes> Articulos_reparto_costes { get; set; }
        public virtual ICollection<Articulos_stocks> Articulos_stocks { get; set; }
        public virtual ICollection<Articulos_stocks_configuracion> Articulos_stocks_configuracion { get; set; }
        public virtual ICollection<Articulos_stocks_conjuntos> Articulos_stocks_conjuntos { get; set; }
        public virtual ICollection<Articulos_tarifas> Articulos_tarifas { get; set; }
        public virtual ICollection<Articulos_tarifas_copia> Articulos_tarifas_copia { get; set; }
        public virtual ICollection<Articulos_tarifas_historico> Articulos_tarifas_historico { get; set; }
        public virtual ICollection<Articulos_tarifas_temporal> Articulos_tarifas_temporal { get; set; }
        public virtual ICollection<Clientes_articulos_bloqueados> Clientes_articulos_bloqueados { get; set; }
        public virtual ICollection<Clientes_articulos_certificados> Clientes_articulos_certificados { get; set; }
        public virtual ICollection<Clientes_grupos_tarifas> Clientes_grupos_tarifas { get; set; }
        public virtual ICollection<Clientes_grupos_tarifas_copia> Clientes_grupos_tarifas_copia { get; set; }
        public virtual ICollection<Clientes_grupos_tarifas_historico> Clientes_grupos_tarifas_historico { get; set; }
        public virtual ICollection<Clientes_grupos_tarifas_temporal> Clientes_grupos_tarifas_temporal { get; set; }
        public virtual ICollection<Clientes_precios_especiales> Clientes_precios_especiales { get; set; }
        public virtual ICollection<Clientes_precios_especiales_cantidad> Clientes_precios_especiales_cantidad { get; set; }
        public virtual ICollection<Clientes_precios_especiales_cantidad_copia> Clientes_precios_especiales_cantidad_copia { get; set; }
        public virtual ICollection<Clientes_precios_especiales_cantidad_historico> Clientes_precios_especiales_cantidad_historico { get; set; }
        public virtual ICollection<Clientes_precios_especiales_cantidad_temporal> Clientes_precios_especiales_cantidad_temporal { get; set; }
        public virtual ICollection<Clientes_precios_especiales_copia> Clientes_precios_especiales_copia { get; set; }
        public virtual ICollection<Clientes_precios_especiales_historico> Clientes_precios_especiales_historico { get; set; }
        public virtual ICollection<Clientes_precios_especiales_temporal> Clientes_precios_especiales_temporal { get; set; }
        public virtual ICollection<Clientes_sinonimos> Clientes_sinonimos { get; set; }
        public virtual ICollection<Competidores_articulos_certificados> Competidores_articulos_certificados { get; set; }
        public virtual ICollection<Competidores_ofertas> Competidores_ofertas { get; set; }
        public virtual ICollection<Compras_albaranes_detalle> Compras_albaranes_detalle { get; set; }
        public virtual ICollection<Compras_facturas_detalle> Compras_facturas_detalle { get; set; }
        public virtual ICollection<Compras_pedidos_detalle> Compras_pedidos_detalle { get; set; }
        public virtual ICollection<Compras_proformas_detalle> Compras_proformas_detalle { get; set; }
        public virtual ICollection<Compras_reclamaciones_detalle> Compras_reclamaciones_detalle { get; set; }
        public virtual ICollection<Ordenes_trabajo> Ordenes_trabajo { get; set; }
        public virtual ICollection<Preparacion_previa_material_unidades> Preparacion_previa_material_unidades { get; set; }
        public virtual ICollection<Preparacion_previa_material_volumen> Preparacion_previa_material_volumen { get; set; }
        public virtual ICollection<Proveedores_articulos_bloqueados> Proveedores_articulos_bloqueados { get; set; }
        public virtual ICollection<Proveedores_precios_compra> Proveedores_precios_compra { get; set; }
        public virtual ICollection<Proveedores_sinonimos> Proveedores_sinonimos { get; set; }
        public virtual ICollection<Troqueles_articulos_proveedores> Troqueles_articulos_proveedores { get; set; }
        public virtual ICollection<Ventas_albaranes_carga> Ventas_albaranes_carga { get; set; }
        public virtual ICollection<Ventas_albaranes_detalle> Ventas_albaranes_detalle { get; set; }
        public virtual ICollection<Ventas_facturas_detalle> Ventas_facturas_detalle { get; set; }
        public virtual ICollection<Ventas_pedidos_detalle> Ventas_pedidos_detalle { get; set; }
        public virtual ICollection<Ventas_proformas_detalle> Ventas_proformas_detalle { get; set; }
        public virtual ICollection<Ventas_reclamaciones_detalle> Ventas_reclamaciones_detalle { get; set; }
        public virtual Articulos_chapa_calidad Chapa_calidadNavigation { get; set; }
        public virtual Articulos_chapa_forma Chapa_formaNavigation { get; set; }
        public virtual Articulos_chapa_medida Chapa_medidaNavigation { get; set; }
        public virtual Proveedores ProveedorNavigation { get; set; }
    }
}
