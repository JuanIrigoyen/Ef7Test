using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Almacen
    {
        public Almacen()
        {
            Almacen_ubicaciones = new HashSet<Almacen_ubicaciones>();
            Articulos_almacen_ubicacion_predeterminada = new HashSet<Articulos_almacen_ubicacion_predeterminada>();
            Articulos_stocks_configuracion = new HashSet<Articulos_stocks_configuracion>();
            Centros_costes_grupos = new HashSet<Centros_costes_grupos>();
            Centros_trabajo = new HashSet<Centros_trabajo>();
            Compras_albaranes_entradas = new HashSet<Compras_albaranes_entradas>();
            Compras_facturas_detalle = new HashSet<Compras_facturas_detalle>();
            Compras_pedidos_cabecera = new HashSet<Compras_pedidos_cabecera>();
            Compras_pedidos_detalle = new HashSet<Compras_pedidos_detalle>();
            Compras_proformas_detalle = new HashSet<Compras_proformas_detalle>();
            Compras_reclamaciones_detalle = new HashSet<Compras_reclamaciones_detalle>();
            Ventas_albaranes_cabecera = new HashSet<Ventas_albaranes_cabecera>();
            Ventas_facturas_detalle = new HashSet<Ventas_facturas_detalle>();
            Ventas_pedidos_detalle = new HashSet<Ventas_pedidos_detalle>();
            Ventas_proformas_detalle = new HashSet<Ventas_proformas_detalle>();
            Ventas_reclamaciones_detalle = new HashSet<Ventas_reclamaciones_detalle>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Nombre { get; set; }
        public bool Principal { get; set; }
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Comunidad { get; set; }
        public string Pais { get; set; }
        public string Cpais { get; set; }
        public string Cpostal { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Movil1 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string VoIp1 { get; set; }
        public string VoIp2 { get; set; }
        public string Internet { get; set; }
        public DateTime? Horario_oficina1 { get; set; }
        public DateTime? Horario_oficina2 { get; set; }
        public DateTime? Horario_descarga1 { get; set; }
        public DateTime? Horario_descarga2 { get; set; }
        public bool Lanzamiento { get; set; }
        public string Observaciones { get; set; }
        public bool Permite_multiples_ubicaciones { get; set; }

        public virtual ICollection<Almacen_ubicaciones> Almacen_ubicaciones { get; set; }
        public virtual ICollection<Articulos_almacen_ubicacion_predeterminada> Articulos_almacen_ubicacion_predeterminada { get; set; }
        public virtual ICollection<Articulos_stocks_configuracion> Articulos_stocks_configuracion { get; set; }
        public virtual ICollection<Centros_costes_grupos> Centros_costes_grupos { get; set; }
        public virtual ICollection<Centros_trabajo> Centros_trabajo { get; set; }
        public virtual ICollection<Compras_albaranes_entradas> Compras_albaranes_entradas { get; set; }
        public virtual ICollection<Compras_facturas_detalle> Compras_facturas_detalle { get; set; }
        public virtual ICollection<Compras_pedidos_cabecera> Compras_pedidos_cabecera { get; set; }
        public virtual ICollection<Compras_pedidos_detalle> Compras_pedidos_detalle { get; set; }
        public virtual ICollection<Compras_proformas_detalle> Compras_proformas_detalle { get; set; }
        public virtual ICollection<Compras_reclamaciones_detalle> Compras_reclamaciones_detalle { get; set; }
        public virtual ICollection<Ventas_albaranes_cabecera> Ventas_albaranes_cabecera { get; set; }
        public virtual ICollection<Ventas_facturas_detalle> Ventas_facturas_detalle { get; set; }
        public virtual ICollection<Ventas_pedidos_detalle> Ventas_pedidos_detalle { get; set; }
        public virtual ICollection<Ventas_proformas_detalle> Ventas_proformas_detalle { get; set; }
        public virtual ICollection<Ventas_reclamaciones_detalle> Ventas_reclamaciones_detalle { get; set; }
    }
}
