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

        // Método para agregar una mascota
        protected void agregarMascota()
        {
            string nombre = txtNombre.Value;
            string especie = txtEspecie.Value;
            string raza = txtRaza.Value;
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Value);
            string color = txtColor.Value;
            double peso = double.Parse(txtPeso.Value);
            string dueñoId = txtDuenoID.Value;
            string adicionadoPor = txtAdicionadoPor.Value;

            bool agregado = MascotaService.Agregar(nombre, especie, raza, fechaNacimiento, color, peso, dueñoId, adicionadoPor);

            if (agregado)
            {
                Response.Write("<script>alert('Mascota agregada correctamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Hubo un error al agregar la mascota');</script>");
            }
        }

        // Método para eliminar una mascota
        protected void eliminarMascota()
        {
            string mascotaId = txtMascotaIDEliminar.Value;

            bool eliminado = MascotaService.Eliminar(mascotaId);

            if (eliminado)
            {
                Response.Write("<script>alert('Mascota eliminada correctamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Hubo un error al eliminar la mascota');</script>");
            }
        }

        // Método para actualizar una mascota
        protected void actualizarMascota()
        {
            string mascotaId = txtMascotaIDActualizar.Value;
            string nombre = txtNombreActualizar.Value;
            string especie = txtEspecieActualizar.Value;
            string raza = txtRazaActualizar.Value;
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimientoActualizar.Value);
            string color = txtColorActualizar.Value;
            double peso = double.Parse(txtPesoActualizar.Value);
            string modificadoPor = txtModificadoPor.Value;

            bool actualizado = MascotaService.Actualizar(mascotaId, nombre, especie, raza, fechaNacimiento, color, peso, modificadoPor);

            if (actualizado)
            {
                Response.Write("<script>alert('Mascota actualizada correctamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Hubo un error al actualizar la mascota');</script>");
            }
        }
    }
}

    