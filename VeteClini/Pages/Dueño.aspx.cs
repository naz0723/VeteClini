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
        // Instancia de la clase de base de datos para ejecutar consultas
        private static DatabaseHelper dh = new DatabaseHelper();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Puedes inicializar variables o cargar datos si es necesario.
        }

        // Evento para agregar un nuevo dueño
        protected void AgregarDueño_Click(object sender, EventArgs e)
        {
            // Obtener los datos ingresados por el usuario
            string nombre = txtNombre.Value;
            string apellido = txtApellido.Value;
            string direccion = txtDireccion.Value;
            string telefono = txtTelefono.Value;
            string email = txtEmail.Value;
            string identificacion = txtIdentificacion.Value;
            string adicionadoPor = txtAdicionadoPor.Value;

            // Llamar al método para agregar el dueño
            bool exito = clsDueño.Agregar(nombre, apellido, direccion, telefono, email, identificacion, adicionadoPor);

            if (exito)
            {
                Response.Write("<script>alert('Dueño agregado exitosamente.');</script>");
            }
            else
            {
                Response.Write("<script>alert('Error al agregar al dueño.');</script>");
            }
        }

        // Evento para eliminar un dueño
        protected void EliminarDueño_Click(object sender, EventArgs e)
        {
            // Verificar si el valor es un número válido antes de intentar convertirlo
            int dueñoID;
            bool isValid = int.TryParse(txtDueñoIDEliminar.Value, out dueñoID);

            if (isValid)
            {
                // Si el valor es un número válido, procede a eliminar
                bool exito = clsDueño.Eliminar(dueñoID);
                if (exito)
                {
                    // Eliminar exitoso
                    Response.Write("<script>alert('Dueño eliminado correctamente');</script>");
                }
                else
                {
                    // Error al eliminar
                    Response.Write("<script>alert('Hubo un error al eliminar al dueño');</script>");
                }
            }
            else
            {
                // Si el valor no es válido, muestra un mensaje de error
                Response.Write("<script>alert('Por favor, ingrese un ID válido');</script>");
            }
        }

        // Evento para actualizar los datos de un dueño
        protected void ActualizarDueño_Click(object sender, EventArgs e)
        {
            // Validar que el valor ingresado sea un número válido
            int dueñoID;
            if (int.TryParse(txtDueñoIDActualizar.Value, out dueñoID))
            {
                // Si la conversión es exitosa, continuar con el proceso de actualización
                string nombre = txtNombreActualizar.Value;
                string apellido = txtApellidoActualizar.Value;
                string direccion = txtDireccionActualizar.Value;
                string telefono = txtTelefonoActualizar.Value;
                string email = txtEmailActualizar.Value;
                string identificacion = txtIdentificacionActualizar.Value;
                string modificadoPor = txtModificadoPor.Value;

                // Llamar al método para actualizar el dueño (debe estar implementado en la clase clsDueño)
                bool exito = clsDueño.Actualizar(dueñoID, nombre, apellido, direccion, telefono, email, identificacion, modificadoPor);

                if (exito)
                {
                    // Mensaje de éxito
                    Response.Write("<script>alert('Dueño actualizado exitosamente.');</script>");
                }
                else
                {
                    // Mensaje de error
                    Response.Write("<script>alert('Error al actualizar al dueño.');</script>");
                }
            }
            else
            {
                // Si la conversión falla, mostrar un mensaje de error
                Response.Write("<script>alert('El ID del dueño debe ser un número válido.');</script>");
            }
        }


        // Evento para redirigir a la página de gestión de mascotas
        protected void Mascotas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mascota.aspx");
        }
    }
}