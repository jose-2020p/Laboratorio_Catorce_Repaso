using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_Catorce_Repaso
{
    public class Tienda_Online_Producto
    {
    
    }
    public class Tienda_Online_Venta
    {
}
    public class Trastienda_Producto_clase
    {
        string codigo_producto;
        string nombre_producto;
        int cantidad_ingreso;
        double precio_compra;
        double precio_venta;

        public string Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public int Cantidad_ingreso { get => cantidad_ingreso; set => cantidad_ingreso = value; }
        public double Precio_compra { get => precio_compra; set => precio_compra = value; }
        public double Precio_venta { get => precio_venta; set => precio_venta = value; }
    }
}