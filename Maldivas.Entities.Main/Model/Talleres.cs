﻿using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Talleres
    {
        public Talleres()
        {
            Talleres_departamentos = new HashSet<Talleres_departamentos>();
            Talleres_visitas = new HashSet<Talleres_visitas>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public int Numero { get; set; }
        public string Nif { get; set; }
        public int? Codigo_direccion { get; set; }
        public string Cliente { get; set; }
        public string Cliente_asociado { get; set; }
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Comunidad { get; set; }
        public string Pais { get; set; }
        public string Cpais { get; set; }
        public string Cpostal { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Telefono3 { get; set; }
        public string Movil1 { get; set; }
        public string Movil2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Voip1 { get; set; }
        public string Voip2 { get; set; }
        public string Internet { get; set; }
        public string Ftp { get; set; }
        public string Usuario { get; set; }
        public string Clave1 { get; set; }
        public string Clave2 { get; set; }
        public DateTime? Fecha_alta { get; set; }
        public byte[] Imagen { get; set; }
        public string Grafico { get; set; }
        public bool Bloqueo_operaciones { get; set; }
        public bool Bloqueo_informacion { get; set; }
        public string Idioma { get; set; }
        public string Observaciones_generales { get; set; }
        public string Observaciones_privadas { get; set; }
        public string Observaciones_administracion { get; set; }
        public string Observaciones_mailing { get; set; }
        public string Observaciones_promocion { get; set; }

        public virtual ICollection<Talleres_departamentos> Talleres_departamentos { get; set; }
        public virtual ICollection<Talleres_visitas> Talleres_visitas { get; set; }
    }
}