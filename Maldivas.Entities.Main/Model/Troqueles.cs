using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Troqueles
    {
        public Troqueles()
        {
            Troqueles_articulos = new HashSet<Troqueles_articulos>();
            Troqueles_empresas = new HashSet<Troqueles_empresas>();
            Troqueles_imagenes = new HashSet<Troqueles_imagenes>();
            Troqueles_movimientos = new HashSet<Troqueles_movimientos>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Referencia_auxiliar { get; set; }
        public string Descripcion { get; set; }
        public string Funcion { get; set; }
        public string Componente { get; set; }
        public string Posicion { get; set; }
        public string Tipo_funcion { get; set; }
        public string Pieza { get; set; }
        public string Mano { get; set; }
        public short? Puestos { get; set; }
        public string Codigo_barras { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Largo { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }
        public int Peso_base_inferior { get; set; }
        public int Peso_base_superior { get; set; }
        public int Peso { get; set; }
        public decimal Porcentaje_peso { get; set; }
        public string Color { get; set; }
        public string Ubicacion_interna { get; set; }
        public string Ubicacion_externa { get; set; }
        public DateTime? Fecha_alta { get; set; }
        public DateTime? Fecha_construccion { get; set; }
        public string Origen { get; set; }
        public string Estado { get; set; }
        public string Orden_trabajo { get; set; }
        public bool Activo { get; set; }
        public string Grafico { get; set; }
        public byte[] Imagen { get; set; }
        public string Observaciones { get; set; }
        public decimal Precio_adquisicion { get; set; }
        public string Divisa { get; set; }
        public string Cuenta { get; set; }
        public decimal Precio_costo { get; set; }

        public virtual ICollection<Troqueles_articulos> Troqueles_articulos { get; set; }
        public virtual ICollection<Troqueles_empresas> Troqueles_empresas { get; set; }
        public virtual ICollection<Troqueles_imagenes> Troqueles_imagenes { get; set; }
        public virtual Troqueles_inventario Troqueles_inventario { get; set; }
        public virtual ICollection<Troqueles_movimientos> Troqueles_movimientos { get; set; }
        public virtual Troqueles_stocks Troqueles_stocks { get; set; }
        public virtual Troqueles_funcion FuncionNavigation { get; set; }
        public virtual Posiciones PosicionNavigation { get; set; }
        public virtual Troqueles_tipos_funcion Tipo_funcionNavigation { get; set; }
    }
}
