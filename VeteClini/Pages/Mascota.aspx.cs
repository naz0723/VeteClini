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
            // Verifica si es la primera carga de la página.
            if (!IsPostBack)
            {
                // Inicialización de datos si es necesario.
            }
        }

        // Método para AgregarMascota una Mascota
        protected void Agregar()
        {
            string nombre = txtNombre.Value;
            string especie = txtEspecie.Value;
            string raza = txtRaza.Value;
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Value);
            string color = txtColor.Value;
            decimal peso = decimal.Parse(txtPeso.Value);
            string dueñoId = txtDuenoID.Value;
            string adicionadoPor = txtAdicionadoPor.Value;

            bool agregado = clsMascota.AgregarMascota(nombre, especie, raza, fechaNacimiento, color, peso, 
                Convert.ToInt32(dueñoId), adicionadoPor);

            if (agregado)
            {
                Response.Write("<script>alert('Mascota agregada correctamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Hubo un error al AgregarMascota la Mascota');</script>");
            }
        }

        // Método para eliminar una Mascota
        protected void eliminarMascota()
        {
            string MascotaId = txtMascotaIDEliminar.Value;

            bool eliminado = clsMascota.EliminarMascota(Convert.ToInt32(MascotaId));

            if (eliminado)
            {
                Response.Write("<script>alert('Mascota eliminada correctamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Hubo un error al eliminar la Mascota');</script>");
            }
        }

        // Método para actualizar una Mascota
        protected void actualizarMascota()
        {
            string MascotaId = txtMascotaIDActualizar.Value;
            string nombre = txtNombreActualizar.Value;
            string especie = txtEspecieActualizar.Value;
            string raza = txtRazaActualizar.Value;
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimientoActualizar.Value);
            string color = txtColorActualizar.Value;
            decimal peso = decimal.Parse(txtPesoActualizar.Value);
            string modificadoPor = txtModificadoPor.Value;

            bool actualizado = clsMascota.ActualizarMascota(Convert.ToInt32(MascotaId), nombre, especie, raza, fechaNacimiento, color, peso, modificadoPor);

            if (actualizado)
            {
                Response.Write("<script>alert('Mascota actualizada correctamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Hubo un error al actualizar la Mascota');</script>");
            }
        }
    }
}

    