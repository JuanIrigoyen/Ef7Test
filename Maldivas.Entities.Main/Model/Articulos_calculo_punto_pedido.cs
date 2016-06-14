using System;
using System.Collections.Generic;

namespace Maldivas.Entities.Main.Model
{
    public partial class Articulos_calculo_punto_pedido
    {
        public string Articulo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Tipo_origen { get; set; }
        public string Familia { get; set; }
        public string Interlocutor { get; set; }
        public int Stock_minimo { get; set; }
        public int Lote_fabricacion { get; set; }
        public string Ejercicio1 { get; set; }
        public string Ejercicio2 { get; set; }
        public string Ejercicio3 { get; set; }
        public string Ejercicio4 { get; set; }
        public string Ejercicio5 { get; set; }
        public string Ejercicio6 { get; set; }
        public string Ejercicio7 { get; set; }
        public string Ejercicio8 { get; set; }
        public string Ejercicio9 { get; set; }
        public string Ejercicio10 { get; set; }
        public int Mes1 { get; set; }
        public int Mes2 { get; set; }
        public int Mes3 { get; set; }
        public int Mes4 { get; set; }
        public int Mes5 { get; set; }
        public int Mes6 { get; set; }
        public int Mes7 { get; set; }
        public int Mes8 { get; set; }
        public int Mes9 { get; set; }
        public int Mes10 { get; set; }
        public int Mes11 { get; set; }
        public int Mes12 { get; set; }
        public int TotalMeses { get; set; }
        public int Media { get; set; }

        public virtual Articulos ArticuloNavigation { get; set; }
    }
}
