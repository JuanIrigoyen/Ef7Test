using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Bancos
    {
        public Bancos()
        {
            Bancos_cuentas = new HashSet<Bancos_cuentas>();
        }

        public string Codigo { get; set; }
        public int Codaux { get; set; }
        public string Nif { get; set; }
        public string Entidad { get; set; }
        public string Agencia { get; set; }
        public bool Remesa { get; set; }
        public string Sufijo { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string Director { get; set; }
        public string Extranjeros { get; set; }
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Comunidad { get; set; }
        public string CPais { get; set; }
        public string Pais { get; set; }
        public string CPostal { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Movil { get; set; }
        public string VoIp1 { get; set; }
        public string VoIp2 { get; set; }
        public string Internet { get; set; }
        public string Ftp { get; set; }
        public string Clave1 { get; set; }
        public string Clave2 { get; set; }
        public string Horario_oficina_desde { get; set; }
        public string Horario_oficina_hasta { get; set; }
        public decimal Forfait { get; set; }
        public decimal Comision { get; set; }
        public decimal Comision_minima { get; set; }
        public string Contrato { get; set; }
        public decimal Gastos_correo { get; set; }
        public decimal Gastos_devolucion { get; set; }
        public decimal Gastos_correo_devolucion { get; set; }
        public bool Timbrado { get; set; }
        public string Grafico { get; set; }
        public byte[] Imagen { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Bancos_cuentas> Bancos_cuentas { get; set; }
    }
}
