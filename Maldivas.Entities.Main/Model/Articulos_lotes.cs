using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_lotes
    {
        public Articulos_lotes()
        {
            Articulos_movimientos = new HashSet<Articulos_movimientos>();
        }

        public int Lote { get; set; }
        public int Operacion { get; set; }
        public string Lote_externo { get; set; }
        public string Lote_proveedor { get; set; }
        public string Etiqueta { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Articulo { get; set; }
        public string Proveedor { get; set; }
        public string Calidad { get; set; }
        public string Referencia { get; set; }
        public string Almacen { get; set; }
        public string Ubicacion { get; set; }
        public int? Pedido_compras { get; set; }
        public int? Albaran_compras { get; set; }
        public int? Inventario { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Peso_neto { get; set; }
        public decimal Peso_bruto { get; set; }
        public decimal Volumen_neto { get; set; }
        public decimal Volumen_bruto { get; set; }
        public bool Captor { get; set; }
        public bool Importado { get; set; }
        public string Personal { get; set; }
        public int? Lanzamiento { get; set; }
        public int? Orden_trabajo { get; set; }
        public string Centro_trabajo { get; set; }
        public short? Fase { get; set; }
        public string Maquina { get; set; }
        public int Tipo { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Articulos_movimientos> Articulos_movimientos { get; set; }
        public virtual Compras_albaranes_cabecera Albaran_comprasNavigation { get; set; }
        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Articulos_chapa_calidad CalidadNavigation { get; set; }
        public virtual Compras_pedidos_cabecera Pedido_comprasNavigation { get; set; }
        public virtual Proveedores ProveedorNavigation { get; set; }
        public virtual Articulos_lotes_tipos TipoNavigation { get; set; }
    }
}
