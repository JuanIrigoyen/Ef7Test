using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Maquinas
    {
        public Maquinas()
        {
            Maquinas_grupos_relacion = new HashSet<Maquinas_grupos_relacion>();
            Maquinas_preventivo_relacion = new HashSet<Maquinas_preventivo_relacion>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Tipo { get; set; }
        public string Abreviatura { get; set; }
        public string Descripcion { get; set; }
        public string Fabricante { get; set; }
        public string Proveedor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Familia { get; set; }
        public string Numero_serie { get; set; }
        public DateTime? Fecha_fabricacion { get; set; }
        public DateTime? Fecha_instalacion { get; set; }
        public DateTime? Fecha_fin_garantia { get; set; }
        public string Seccion { get; set; }
        public string Centro { get; set; }
        public int Largo { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }
        public decimal Peso { get; set; }
        public byte[] Imagen { get; set; }
        public string Grafico { get; set; }
        public int Potencia_electrica { get; set; }
        public bool Automantenimiento { get; set; }
        public bool Mantenimiento_preventivo { get; set; }
        public bool Mantenimiento_predictivo { get; set; }
        public string Observaciones { get; set; }
        public decimal Prensas { get; set; }
        public decimal Inmuebles { get; set; }
        public decimal Consumos { get; set; }
        public decimal Auxiliares { get; set; }
        public decimal Estructuras { get; set; }
        public decimal? Total_maquina { get; set; }
        public decimal Mo_operador { get; set; }
        public decimal Mo_operario { get; set; }
        public decimal Horas_disponibles { get; set; }

        public virtual ICollection<Maquinas_grupos_relacion> Maquinas_grupos_relacion { get; set; }
        public virtual ICollection<Maquinas_preventivo_relacion> Maquinas_preventivo_relacion { get; set; }
    }
}
