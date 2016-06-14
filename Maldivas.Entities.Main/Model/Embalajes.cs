using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Embalajes
    {
        public Embalajes()
        {
            Articulos_embalajes = new HashSet<Articulos_embalajes>();
            Clientes_embalajes_configuracion = new HashSet<Clientes_embalajes_configuracion>();
            Compras_pedidos_detalle = new HashSet<Compras_pedidos_detalle>();
            Embalajes_idiomas = new HashSet<Embalajes_idiomas>();
            Ventas_albaranes_embalajes = new HashSet<Ventas_albaranes_embalajes>();
            Ventas_facturas_embalajes = new HashSet<Ventas_facturas_embalajes>();
            Ventas_pedidos_detalle = new HashSet<Ventas_pedidos_detalle>();
            Ventas_pedidos_embalajes = new HashSet<Ventas_pedidos_embalajes>();
            Ventas_proformas_detalle = new HashSet<Ventas_proformas_detalle>();
            Ventas_proformas_embalajes = new HashSet<Ventas_proformas_embalajes>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string ValorCodigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Valor { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Peso { get; set; }
        public decimal Volumen { get; set; }
        public decimal Precio_costo { get; set; }
        public decimal Precio_mano_obra { get; set; }
        public bool Activo { get; set; }
        public byte[] Imagen { get; set; }
        public string Grafico { get; set; }
        public string Tipo_embalaje { get; set; }
        public bool Control_stocks { get; set; }
        public string Observaciones { get; set; }
        public decimal? Altura { get; set; }
        public decimal? Anchura { get; set; }

        public virtual ICollection<Articulos_embalajes> Articulos_embalajes { get; set; }
        public virtual ICollection<Clientes_embalajes_configuracion> Clientes_embalajes_configuracion { get; set; }
        public virtual ICollection<Compras_pedidos_detalle> Compras_pedidos_detalle { get; set; }
        public virtual ICollection<Embalajes_idiomas> Embalajes_idiomas { get; set; }
        public virtual ICollection<Ventas_albaranes_embalajes> Ventas_albaranes_embalajes { get; set; }
        public virtual ICollection<Ventas_facturas_embalajes> Ventas_facturas_embalajes { get; set; }
        public virtual ICollection<Ventas_pedidos_detalle> Ventas_pedidos_detalle { get; set; }
        public virtual ICollection<Ventas_pedidos_embalajes> Ventas_pedidos_embalajes { get; set; }
        public virtual ICollection<Ventas_proformas_detalle> Ventas_proformas_detalle { get; set; }
        public virtual ICollection<Ventas_proformas_embalajes> Ventas_proformas_embalajes { get; set; }
    }
}
