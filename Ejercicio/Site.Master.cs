using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false) 
            {
                // Productos
                tipop.Items.Add(new ListItem("Cereales", "1"));
                tipop.Items.Add(new ListItem("Menestras", "2"));
                tipop.Items.Add(new ListItem("Carne de res", "3"));
                tipop.Items.Add(new ListItem("Pollo", "4"));

                // Nombre Empresas
                nombreEmpresa.Items.Add(new ListItem("Gloria", "1"));
                nombreEmpresa.Items.Add(new ListItem("Rico Pollo", "2"));
                nombreEmpresa.Items.Add(new ListItem("Tottus", "3"));
                nombreEmpresa.Items.Add(new ListItem("Promart", "4"));

                productos.Visible = true;
                clientes.Visible = false;
                proveedor.Visible = false;
            }
        }

        protected void mostrarFromProductos(Object sender, EventArgs e)
        {
            productos.Visible = true;
            clientes.Visible = false;
            proveedor.Visible = false;
        }

        protected void mostrarFromClientes(Object sender, EventArgs e)
        {
            productos.Visible = false;
            clientes.Visible = true;
            proveedor.Visible = false;
        }

        protected void mostrarFromProveedores(Object sender, EventArgs e)
        {
            productos.Visible = false;
            clientes.Visible = false;
            proveedor.Visible = true;
        }

        protected void crearProducto(Object sender, EventArgs e)
        {
            ListItem productos = tipop.Items[tipop.SelectedIndex];

            contenedorRes.InnerHtml =
                    "<h2>Ha ingresado los siguientes datos:</h2>" +
                    "<p> 1. " + nombrep.Value + "</p>" +
                    "<p> 2. " + productos.Text + "</p>" +
                    "<p> 3. " + descripcionp.Value + "</p>" +
                    "<p> 4. " + cantidadp.Value + "</p>" +
                    "<p> 5. " + preciop.Value + "</p>";
        }

        protected void crearClientes(Object sender, EventArgs e)
        {
            contenedorRes.InnerHtml =
                    "<h2>Ha ingresado los siguientes datos:</h2>" +
                    "<p> 1. " + nombresc.Value + "</p>" +
                    "<p> 2. " + apellidoc.Value + "</p>" +
                    "<p> 3. " + telefonoc.Value + "</p>" +
                    "<p> 4. " + mailc.Value + "</p>";
        }

        protected void crearProveedor(Object sender, EventArgs e)
        {
            ListItem proveedor = nombreEmpresa.Items[nombreEmpresa.SelectedIndex];

            contenedorRes.InnerHtml =
                    "<h2>Ha ingresado los siguientes datos:</h2>" +
                    "<p> 1. " + nombrespr.Value + "</p>" +
                    "<p> 2. " + apellidopr.Value + "</p>" +
                    "<p> 3. " + telefonopr.Value + "</p>" +
                    "<p> 4. " + proveedor.Text + "</p>" +
                    "<p> 5. " + direccionpr.Value + "</p>";
        }
    }
}