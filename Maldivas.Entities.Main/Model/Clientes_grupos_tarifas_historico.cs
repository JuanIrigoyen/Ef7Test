﻿using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_grupos_tarifas_historico
    {
        public int Codigo { get; set; }
        public string Grupo { get; set; }
        public string Articulo { get; set; }
        public string Situacion { get; set; }
        public DateTime? Fecha_inicio { get; set; }
        public DateTime? Fecha_final { get; set; }
        public decimal Descuento { get; set; }
        public decimal Recargo { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public string Divisa { get; set; }
        public decimal Precio_anterior { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Clientes_grupos_tarifas_tipos GrupoNavigation { get; set; }
    }
}
