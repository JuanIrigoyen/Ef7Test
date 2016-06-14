﻿using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Clientes_precios_especiales_cantidad_historico
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public string Articulo { get; set; }
        public int Cantidad_inicial { get; set; }
        public int Cantidad_final { get; set; }
        public string Situacion { get; set; }
        public DateTime? Fecha_inicio { get; set; }
        public DateTime? Fecha_final { get; set; }
        public decimal Recargo { get; set; }
        public decimal Descuento { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public string Divisa { get; set; }
        public decimal Precio_anterior { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
        public virtual Clientes ClienteNavigation { get; set; }
    }
}