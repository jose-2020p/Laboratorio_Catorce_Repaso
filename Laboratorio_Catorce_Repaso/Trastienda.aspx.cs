using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_Catorce_Repaso
{
    public partial class Trastienda : System.Web.UI.Page
    {
        static List<Trastienda_Producto_clase> vector_producto = new List<Trastienda_Producto_clase>();

        protected void Page_Load(object sender, EventArgs e)
        {
            MaintainScrollPositionOnPostBack = true;
           if (!IsPostBack) 
           {
                string archivo = Server.MapPath("Producto.json");
                StreamReader jsonStream = File.OpenText(archivo);
                string json = jsonStream.ReadToEnd();
                jsonStream.Close();
                if (json.Length > 0)
                {
                    vector_producto = JsonConvert.DeserializeObject<List<Trastienda_Producto_clase>>(json);
                    GridView1.DataSource = vector_producto;
                    GridView1.DataBind();
                }
           }

        }

        public void Guardar() 
        {
            string json = JsonConvert.SerializeObject(vector_producto);
            string archivo = Server.MapPath("Producto.json");
            System.IO.File.WriteAllText(archivo,json);
        }
        public void agregar_producto_nuevo() 
        {
            if (vector_producto.Count == 0 | vector_producto.Count >=1)
            {
                Trastienda_Producto_clase nuevo_producto = new Trastienda_Producto_clase();
                nuevo_producto.Codigo_producto = TextBox1.Text;
                nuevo_producto.Nombre_producto = TextBox2.Text;
                nuevo_producto.Cantidad_ingreso = Convert.ToInt16(TextBox3.Text);
                nuevo_producto.Precio_compra = Convert.ToDouble(TextBox4.Text);
                nuevo_producto.Precio_venta = Convert.ToDouble(TextBox5.Text);

                string ruta_imagen = Path.GetFileName(FileUpload1.FileName);
                try 
                {
                    FileUpload1.SaveAs(Server.MapPath("~/Imagenes/") + ruta_imagen);
                }
                catch (Exception ex)
                {
                    Label2.Text = "Se genero el siguiente error: " + ex.Message;
                }
                string archivo = "~/Imagenes/" + FileUpload1.FileName;
                nuevo_producto.Imagen = archivo;
                vector_producto.Add(nuevo_producto);
            }
            if (GridView1.SelectedIndex >= 0)
            {
                // al ingresar un producto existente
                int existente = GridView1.SelectedIndex;
                vector_producto[existente].Cantidad_ingreso =Convert.ToInt32(TextBox3.Text);

            }
            GridView1.DataSource = vector_producto;
            GridView1.DataBind();
            Guardar();
            ButtonAgregar_P.Text = "Agregar producto";
            TextBox3.Text = "";
            Label1.Text = "";
        }
        protected void ButtonAgregar_P_Click(object sender, EventArgs e)
        {
            agregar_producto_nuevo();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // al ingresar un producto existente
            int producto_seleccionado = GridView1.SelectedIndex;
            ButtonAgregar_P.Text ="Guardar Cambios";
            TextBox3.Text = Convert.ToString(vector_producto[producto_seleccionado].Cantidad_ingreso);
            Label1.Text = "Realice los cambios y luego oprima el boton GUARDAR CAMBIOS";
        }
    }
}