using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Centros_costes
    {
        public Centros_costes()
        {
            Articulos_fases = new HashSet<Articulos_fases>();
            Centros_costes_grupos_relacion = new HashSet<Centros_costes_grupos_relacion>();
            Centros_costes_maquinas = new HashSet<Centros_costes_maquinas>();
        }

        public string Codigo { get; set; }
        public int? Codaux { get; set; }
        public string Codigo_captor { get; set; }
        public string Descripcion { get; set; }
        public decimal Coste_hora_maquina { get; set; }
        public decimal Coste_hora_modificar { get; set; }
        public int Tiempo_trasferencia { get; set; }
        public string Nemonico { get; set; }
        public string Observaciones { get; set; }
        public int Horas_disponibles_dia { get; set; }
        public string Habil_preparacion { get; set; }
        public string Habil_operacion { get; set; }
        public string Seccion { get; set; }
        public decimal Coste_centro { get; set; }

        public virtual ICollection<Articulos_fases> Articulos_fases { get; set; }
        public virtual ICollection<Centros_costes_grupos_relacion> Centros_costes_grupos_relacion { get; set; }
        public virtual ICollection<Centros_costes_maquinas> Centros_costes_maquinas { get; set; }
    }
}
