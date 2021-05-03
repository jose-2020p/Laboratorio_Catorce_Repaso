using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_Catorce_Repaso
{
    public class Tienda_Online_Producto
    {
        string nombre_producto_venta;
        string precio_producto_venta;

        public string Nombre_producto_venta { get => nombre_producto_venta; set => nombre_producto_venta = value; }
        public string Precio_producto_venta { get => precio_producto_venta; set => precio_producto_venta = value; }
    }
    public class Tienda_Online_Venta 
    {
        // Aca se enmarcaran cada uno de los detelles de la venta
        string estado_producto_venta = "En proceso";
        string nombre_cliente_venta;
        string nit_cliente_venta;
        int numero_compra_venta = 1;
        List<Tienda_Online_Producto> vector_producto_lista = new List<Tienda_Online_Producto>();

        public string Estado_producto_venta { get => estado_producto_venta; set => estado_producto_venta = value; }
        public string Nombre_cliente_venta { get => nombre_cliente_venta; set => nombre_cliente_venta = value; }
        public string Nit_cliente_venta { get => nit_cliente_venta; set => nit_cliente_venta = value; }
        public int Numero_compra_venta { get => numero_compra_venta; set => numero_compra_venta = value; }
        public List<Tienda_Online_Producto> Producto_lista { get => producto_lista; set => producto_lista = value; }
    public Tienda_Online_Producto
    
    }
    public class Trastienda_Producto
    {

        //En la trastienda se tienes las siguientes caractersiticas que se guardaran en algun archivo
        //para poder ver el estado de nuestro inventario

        string nombre_producto_inventario;
        string precio_producto_inventario;
        int existencia_producto_inventario;

        public string Nombre_producto_inventario { get => nombre_producto_inventario; set => nombre_producto_inventario = value; }
        public string Precio_producto_inventario { get => precio_producto_inventario; set => precio_producto_inventario = value; }
        public int Existencia_producto_inventario { get => existencia_producto_inventario; set => existencia_producto_inventario = value; }
    }
}