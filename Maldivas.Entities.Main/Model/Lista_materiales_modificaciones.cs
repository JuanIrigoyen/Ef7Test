using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Lista_materiales_modificaciones
    {
        public int Codigo { get; set; }
        public string Lista { get; set; }
        public string Referencia { get; set; }
        public DateTime? Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Cliente { get; set; }
        public string Observaciones { get; set; }
        public decimal Horas_oficina_tecnica_estimadas { get; set; }
        public decimal Horas_cad_estimadas { get; set; }
        public decimal Horas_maquinas_2d_estimadas { get; set; }
        public decimal Horas_maquinas_3d_estimadas { get; set; }
        public decimal Horas_ajuste_estimadas { get; set; }
        public decimal Materiales_estimados { get; set; }
        public decimal Tratamientos_estimados { get; set; }
        public decimal Valoracion_economica_estimada { get; set; }
        public decimal Horas_oficina_tecnica_real { get; set; }
        public decimal Horas_cad_real { get; set; }
        public decimal Horas_maquinas_2d_real { get; set; }
        public decimal Horas_maquinas_3d_real { get; set; }
        public decimal Horas_ajuste_real { get; set; }
        public decimal Materiales_real { get; set; }
        public decimal Tratamientos_real { get; set; }
        public decimal Coste_real { get; set; }
    }
}
