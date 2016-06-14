using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Estadisticas
    {
        public Estadisticas()
        {
            Estadisticas_usuarios = new HashSet<Estadisticas_usuarios>();
            Scheduler_configuracion = new HashSet<Scheduler_configuracion>();
        }

        public int Clave { get; set; }
        public int? Padre { get; set; }
        public string Descripcion { get; set; }
        public short? Imagen { get; set; }
        public string Informe { get; set; }
        public string Ruta { get; set; }
        public string Consulta { get; set; }
        public bool Activa { get; set; }
        public bool Listas_corchetes { get; set; }
        public string Lista1 { get; set; }
        public int? ListaCodigo1 { get; set; }
        public string Lista2 { get; set; }
        public int? ListaCodigo2 { get; set; }
        public string Lista3 { get; set; }
        public int? ListaCodigo3 { get; set; }
        public string Lista4 { get; set; }
        public int? ListaCodigo4 { get; set; }
        public string Lista5 { get; set; }
        public int? ListaCodigo5 { get; set; }
        public string Metodo { get; set; }
        public bool? Acceso { get; set; }
        public string Controles { get; set; }
        public string Observaciones { get; set; }
        public int Contador { get; set; }
        public DateTime? Fecha_ultima_ejecucion { get; set; }

        public virtual ICollection<Estadisticas_usuarios> Estadisticas_usuarios { get; set; }
        public virtual ICollection<Scheduler_configuracion> Scheduler_configuracion { get; set; }
    }
}
