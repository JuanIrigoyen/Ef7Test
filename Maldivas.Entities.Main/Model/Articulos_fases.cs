using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_fases
    {
        public string Articulo { get; set; }
        public int Fase { get; set; }
        public int Orden { get; set; }
        public string Centro_produccion { get; set; }
        public string Centro_coste { get; set; }
        public bool Centro_predeterminado { get; set; }
        public string Centro_destino { get; set; }
        public long Tiempo_fase { get; set; }
        public int Operarios_fase { get; set; }
        public int Ciclos_hora { get; set; }
        public double Piezas_ciclo { get; set; }
        public string Codigo_versiones { get; set; }
        public bool Generar_ot { get; set; }
        public bool Cierre_reserva { get; set; }
        public string Observaciones { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Centros_costes Centro_costeNavigation { get; set; }
        public virtual Centros_trabajo Centro_produccionNavigation { get; set; }
        public virtual Fases FaseNavigation { get; set; }
    }
}
