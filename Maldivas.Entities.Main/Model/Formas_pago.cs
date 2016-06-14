using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Formas_pago
    {
        public Formas_pago()
        {
            Compras_albaranes_cabecera = new HashSet<Compras_albaranes_cabecera>();
            Compras_pedidos_cabecera = new HashSet<Compras_pedidos_cabecera>();
            Compras_proformas_cabecera = new HashSet<Compras_proformas_cabecera>();
            Formas_pago_idiomas = new HashSet<Formas_pago_idiomas>();
            Ventas_albaranes_cabecera = new HashSet<Ventas_albaranes_cabecera>();
            Ventas_proformas_cabecera = new HashSet<Ventas_proformas_cabecera>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public byte Tipo_aplazamiento { get; set; }
        public byte Tipo_recibos { get; set; }
        public byte Dia_1_pago { get; set; }
        public byte Dia_2_pago { get; set; }
        public byte Dia_3_pago { get; set; }
        public short Carencia { get; set; }
        public short Aplazamiento { get; set; }
        public byte Plazos { get; set; }
        public decimal Entrada { get; set; }
        public decimal Recargo { get; set; }
        public decimal Descuento { get; set; }
        public decimal Importe { get; set; }
        public bool Ajuste_vacaciones { get; set; }
        public decimal Porcentaje_aplazamiento_1 { get; set; }
        public short Dias_aplazamiento_1 { get; set; }
        public byte Dia_pago_1 { get; set; }
        public decimal Porcentaje_aplazamiento_2 { get; set; }
        public short Dias_aplazamiento_2 { get; set; }
        public byte Dia_pago_2 { get; set; }
        public decimal Porcentaje_aplazamiento_3 { get; set; }
        public short Dias_aplazamiento_3 { get; set; }
        public byte Dia_pago_3 { get; set; }
        public decimal Porcentaje_aplazamiento_4 { get; set; }
        public short Dias_aplazamiento_4 { get; set; }
        public byte Dia_pago_4 { get; set; }
        public decimal Porcentaje_aplazamiento_5 { get; set; }
        public short Dias_aplazamiento_5 { get; set; }
        public byte Dia_pago_5 { get; set; }
        public decimal Porcentaje_aplazamiento_6 { get; set; }
        public short Dias_aplazamiento_6 { get; set; }
        public byte Dia_pago_6 { get; set; }
        public decimal Porcentaje_aplazamiento_7 { get; set; }
        public short Dias_aplazamiento_7 { get; set; }
        public byte Dia_pago_7 { get; set; }
        public decimal Porcentaje_aplazamiento_8 { get; set; }
        public short Dias_aplazamiento_8 { get; set; }
        public byte Dia_pago_8 { get; set; }
        public decimal Porcentaje_aplazamiento_9 { get; set; }
        public short Dias_aplazamiento_9 { get; set; }
        public byte Dia_pago_9 { get; set; }
        public decimal Porcentaje_aplazamiento_10 { get; set; }
        public short Dias_aplazamiento_10 { get; set; }
        public byte Dia_pago_10 { get; set; }
        public decimal Porcentaje_aplazamiento_11 { get; set; }
        public short Dias_aplazamiento_11 { get; set; }
        public byte Dia_pago_11 { get; set; }
        public decimal Porcentaje_aplazamiento_12 { get; set; }
        public short Dias_aplazamiento_12 { get; set; }
        public byte Dia_pago_12 { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Compras_albaranes_cabecera> Compras_albaranes_cabecera { get; set; }
        public virtual ICollection<Compras_pedidos_cabecera> Compras_pedidos_cabecera { get; set; }
        public virtual ICollection<Compras_proformas_cabecera> Compras_proformas_cabecera { get; set; }
        public virtual ICollection<Formas_pago_idiomas> Formas_pago_idiomas { get; set; }
        public virtual ICollection<Ventas_albaranes_cabecera> Ventas_albaranes_cabecera { get; set; }
        public virtual ICollection<Ventas_proformas_cabecera> Ventas_proformas_cabecera { get; set; }
    }
}
