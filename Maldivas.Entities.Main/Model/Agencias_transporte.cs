using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Agencias_transporte
    {
        public Agencias_transporte()
        {
            Agencias_transporte_costes_envios = new HashSet<Agencias_transporte_costes_envios>();
            Agencias_transporte_departamentos = new HashSet<Agencias_transporte_departamentos>();
            Agencias_transporte_matriculas = new HashSet<Agencias_transporte_matriculas>();
            Agencias_transporte_tarifas = new HashSet<Agencias_transporte_tarifas>();
            Agencias_transporte_visitas = new HashSet<Agencias_transporte_visitas>();
            Agencias_transporte_zonas = new HashSet<Agencias_transporte_zonas>();
            Clientes_transporte_expediciones = new HashSet<Clientes_transporte_expediciones>();
            Proveedores_transporte_expediciones = new HashSet<Proveedores_transporte_expediciones>();
            Transportistas_evaluacion = new HashSet<Transportistas_evaluacion>();
            Ventas_albaranes_cabecera = new HashSet<Ventas_albaranes_cabecera>();
            Ventas_pedidos_cabecera = new HashSet<Ventas_pedidos_cabecera>();
            Ventas_proformas_cabecera = new HashSet<Ventas_proformas_cabecera>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Nif { get; set; }
        public int? Codigo_direccion { get; set; }
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
        public string Horario_oficina1 { get; set; }
        public string Horario_oficina2 { get; set; }
        public string Horario_descarga1 { get; set; }
        public string Horario_descarga2 { get; set; }
        public string Vacaciones_inicio { get; set; }
        public string Vacaciones_final { get; set; }
        public DateTime? Fecha_alta { get; set; }
        public byte[] Imagen { get; set; }
        public string Grafico { get; set; }
        public bool Bloqueo_operaciones { get; set; }
        public bool Bloqueo_informacion { get; set; }
        public string Transporte_tipo { get; set; }
        public bool? Transporte_reexpedicion { get; set; }
        public decimal Transporte_reexpedicion_descuento { get; set; }
        public decimal Transporte_seguro { get; set; }
        public decimal Transporte_seguro_minimo { get; set; }
        public decimal Transporte_fijo { get; set; }
        public decimal Transporte_peso_minimo { get; set; }
        public decimal Transporte_coste_minimo { get; set; }
        public decimal Transporte_indemnizacion_kg { get; set; }
        public decimal Transporte_indemnizacion_maxima { get; set; }
        public decimal Transporte_factor { get; set; }
        public decimal Transporte_tarifa_descuento { get; set; }
        public bool Transporte_transportista { get; set; }
        public string Divisa { get; set; }
        public string Idioma { get; set; }
        public string Observaciones_generales { get; set; }
        public string Observaciones_privadas { get; set; }
        public string Observaciones_administracion { get; set; }

        public virtual ICollection<Agencias_transporte_costes_envios> Agencias_transporte_costes_envios { get; set; }
        public virtual ICollection<Agencias_transporte_departamentos> Agencias_transporte_departamentos { get; set; }
        public virtual ICollection<Agencias_transporte_matriculas> Agencias_transporte_matriculas { get; set; }
        public virtual ICollection<Agencias_transporte_tarifas> Agencias_transporte_tarifas { get; set; }
        public virtual ICollection<Agencias_transporte_visitas> Agencias_transporte_visitas { get; set; }
        public virtual ICollection<Agencias_transporte_zonas> Agencias_transporte_zonas { get; set; }
        public virtual ICollection<Clientes_transporte_expediciones> Clientes_transporte_expediciones { get; set; }
        public virtual ICollection<Proveedores_transporte_expediciones> Proveedores_transporte_expediciones { get; set; }
        public virtual ICollection<Transportistas_evaluacion> Transportistas_evaluacion { get; set; }
        public virtual ICollection<Ventas_albaranes_cabecera> Ventas_albaranes_cabecera { get; set; }
        public virtual ICollection<Ventas_pedidos_cabecera> Ventas_pedidos_cabecera { get; set; }
        public virtual ICollection<Ventas_proformas_cabecera> Ventas_proformas_cabecera { get; set; }
    }
}
