using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Ivas
    {
        public Ivas()
        {
            Compras_albaranes_cabecera = new HashSet<Compras_albaranes_cabecera>();
            Compras_albaranes_detalle = new HashSet<Compras_albaranes_detalle>();
            Compras_facturas_cabecera = new HashSet<Compras_facturas_cabecera>();
            Compras_facturas_detalle = new HashSet<Compras_facturas_detalle>();
            Compras_pedidos_cabecera = new HashSet<Compras_pedidos_cabecera>();
            Compras_pedidos_detalle = new HashSet<Compras_pedidos_detalle>();
            Compras_proformas_cabecera = new HashSet<Compras_proformas_cabecera>();
            Compras_proformas_detalle = new HashSet<Compras_proformas_detalle>();
            Ventas_albaranes_cabecera = new HashSet<Ventas_albaranes_cabecera>();
            Ventas_facturas_cabecera = new HashSet<Ventas_facturas_cabecera>();
            Ventas_pedidos_detalle = new HashSet<Ventas_pedidos_detalle>();
        }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Subcuenta { get; set; }
        public decimal Impuesto_porcentaje { get; set; }
        public decimal Impuesto_porcentaje_libro_iva { get; set; }
        public decimal Recargo_porcentaje { get; set; }
        public decimal Recargo_porcentaje_libro_iva { get; set; }
        public decimal Deducible_porcentaje { get; set; }
        public string Categoria { get; set; }
        public decimal Iva_contable { get; set; }
        public bool Adquisicion_intracomunitaria { get; set; }
        public bool Igic { get; set; }

        public virtual ICollection<Compras_albaranes_cabecera> Compras_albaranes_cabecera { get; set; }
        public virtual ICollection<Compras_albaranes_detalle> Compras_albaranes_detalle { get; set; }
        public virtual ICollection<Compras_facturas_cabecera> Compras_facturas_cabecera { get; set; }
        public virtual ICollection<Compras_facturas_detalle> Compras_facturas_detalle { get; set; }
        public virtual ICollection<Compras_pedidos_cabecera> Compras_pedidos_cabecera { get; set; }
        public virtual ICollection<Compras_pedidos_detalle> Compras_pedidos_detalle { get; set; }
        public virtual ICollection<Compras_proformas_cabecera> Compras_proformas_cabecera { get; set; }
        public virtual ICollection<Compras_proformas_detalle> Compras_proformas_detalle { get; set; }
        public virtual ICollection<Ventas_albaranes_cabecera> Ventas_albaranes_cabecera { get; set; }
        public virtual ICollection<Ventas_facturas_cabecera> Ventas_facturas_cabecera { get; set; }
        public virtual ICollection<Ventas_pedidos_detalle> Ventas_pedidos_detalle { get; set; }
        public virtual Ivas_categorias CategoriaNavigation { get; set; }
    }
}
