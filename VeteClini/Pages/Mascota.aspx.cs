using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VeteClini.Pages
{
    public partial class Mascota : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Aquí puedes cargar información inicial si lo necesitas.
        }

        // Método para agregar una mascota
        protected void AgregarMascota_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Value;
            string especie = txtEspecie.Value;
            string raza = txtRaza.Value;
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Value);
            string color = txtColor.Value;
            decimal peso = decimal.Parse(txtPeso.Value);
            int duenoID = int.Parse(txtDueñoID.Value);
            string adicionadoPor = txtAdicionadoPor.Value;

            bool exito = clsMascota.AgregarMascota(nombre, especie, raza, fechaNacimiento, color, peso, duenoID, adicionadoPor);
            if (exito)
            {
                Response.Write("<script>alert('Mascota agregada con exito');</script>");
            }
            else
            {
                Response.Write("<script>alert('Error al agregar Mascota');</script>");
            }
        }

        // Método para actualizar una mascota
        protected void ActualizarMascota_Click(object sender, EventArgs e)
        {
            int mascotaID = int.Parse(txtMascotaIDEliminar.Value);
            string nombre = txtNombre.Value;
            string especie = txtEspecie.Value;
            string raza = txtRaza.Value;
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Value);
            string color = txtColor.Value;
            decimal peso = decimal.Parse(txtPeso.Value);
            string modificadoPor = txtAdicionadoPor.Value;

            bool exito = clsMascota.ActualizarMascota(mascotaID, nombre, especie, raza, fechaNacimiento, color, peso, modificadoPor);
            if (exito)
            {
                Response.Write("<script>alert('Mascota actualizada con exito');</script>");
            }
            else
            {
                Response.Write("<script>alert('Mascota no actualizada error');</script>");
            }
        }

        // Método para eliminar una mascota
        protected void EliminarMascota_Click(object sender, EventArgs e)
        {
            int mascotaID = int.Parse(txtMascotaIDEliminar.Value);

            bool exito = clsMascota.EliminarMascota(mascotaID);
            if (exito)
            {
                Response.Write("<script>alert('Mascota Eliminada con exito');</script>");
            }
            else
            {
                Response.Write("<script>alert('Error al agregar Mascota');</script>");
            }
        }

        // Método manejador de eventos para el botón "Historial Clinico"
        protected void HistorialClinico_Click(object sender, EventArgs e)
        {
            // Lógica de redirección u otra acción
            Response.Redirect("HistorialClinico.aspx");
        }
    }
}