using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VeteClini.Pages
{
    public partial class Dueño : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verifica si es la primera carga de la página.
            if (!IsPostBack)
            {
                // Inicialización de datos si es necesario.
            }
        }

        // Método para agregar un dueño
        protected void AgregarDueño_Click(object sender, EventArgs e)
        {
            // Captura los datos ingresados en los controles del formulario
            string nombre = txtNombre.Value;
            string apellido = txtApellido.Value;
            string direccion = txtDireccion.Value;
            string telefono = txtTelefono.Value;
            string email = txtEmail.Value;
            string identificacion = txtIdentificacion.Value;
            string adicionadoPor = txtAdicionadoPor.Value;

            // Realiza la lógica de inserción a la base de datos aquí
            // Puedes llamar a una clase de servicio o un repositorio
            bool agregado = clsDueño.Agregar(nombre, apellido, direccion, telefono, email, identificacion, adicionadoPor);

           /* // Muestra un mensaje de confirmación o error
            if (agregado)
            {
                Response.Write("<script>alert('Dueño agregado correctamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Hubo un error al agregar el dueño');</script>");
            }*/
        }

        // Método para eliminar un dueño
        protected void eliminarDueño()
        {
            string dueñoId = txtDueñoIDEliminar.Value;

           bool eliminado = clsDueño.Eliminar(Convert.ToInt32(dueñoId));

            if (eliminado)
            {
                Response.Write("<script>alert('Dueño eliminado correctamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Hubo un error al eliminar el dueño');</script>");
            }
        }

        // Método para actualizar un dueño
        protected void actualizarDueño()
        {
            string dueñoId = txtDueñoIDActualizar.Value;
            string nombre = txtNombreActualizar.Value;
            string apellido = txtApellidoActualizar.Value;
            string direccion = txtDireccionActualizar.Value;
            string telefono = txtTelefonoActualizar.Value;
            string email = txtEmailActualizar.Value;
            string identificacion = txtIdentificacionActualizar.Value;
            string modificadoPor = txtModificadoPor.Value;

            bool actualizado = clsDueño.Actualizar(Convert.ToInt32(dueñoId), nombre, apellido, direccion, telefono, email, identificacion, modificadoPor);

            if (actualizado)
            {
                Response.Write("<script>alert('Dueño actualizado correctamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Hubo un error al actualizar el dueño');</script>");
            } 
        }
    }
}
