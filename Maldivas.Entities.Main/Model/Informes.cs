using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Informes
    {
        public Informes()
        {
            Informes_formatos = new HashSet<Informes_formatos>();
            Scheduler_configuracion = new HashSet<Scheduler_configuracion>();
        }

        public int Informe { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public int Orden { get; set; }
        public string Modulo { get; set; }
        public string Directorio_server { get; set; }
        public string Directorio { get; set; }
        public string Generador { get; set; }
        public byte[] Propiedades_impresion { get; set; }
        public bool Parametros { get; set; }
        public byte[] Informe_xtra { get; set; }
        public short Copias { get; set; }
        public bool Consola_impresion { get; set; }
        public bool Filtro { get; set; }
        public bool Duplex { get; set; }
        public short Query_defecto { get; set; }
        public string Query1 { get; set; }
        public string Query2 { get; set; }
        public string Query3 { get; set; }
        public string Query4 { get; set; }
        public string Query5 { get; set; }
        public string Query6 { get; set; }
        public string Query7 { get; set; }
        public string Query8 { get; set; }
        public string Query9 { get; set; }
        public string Query10 { get; set; }
        public string Idioma { get; set; }
        public string Base_datos { get; set; }
        public int? Informe_anidado1 { get; set; }
        public int? Informe_anidado2 { get; set; }
        public int? Informe_anidado3 { get; set; }
        public int? Informe_anidado4 { get; set; }
        public int? Informe_anidado5 { get; set; }
        public int? Informe_anidado6 { get; set; }
        public string Asunto { get; set; }
        public string Body { get; set; }
        public bool Cabecera { get; set; }
        public bool Traducir { get; set; }
        public bool Editando { get; set; }
        public bool Aviso_margenes { get; set; }

        public virtual ICollection<Informes_formatos> Informes_formatos { get; set; }
        public virtual ICollection<Scheduler_configuracion> Scheduler_configuracion { get; set; }
    }
}
