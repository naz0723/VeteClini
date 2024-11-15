using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VeteClini.Pages
{
    public partial class HistorialClinico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Este método se llama cuando la página se carga.
        }
        protected void AgregarHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                // Recoger los valores de los controles TextBox
                DateTime fechaVisita = DateTime.Parse(txtFechaVisita.Text);
                string sintomas = txtSintomas.Text;
                string diagnostico = txtDiagnostico.Text;
                string tratamiento = txtTratamiento.Text;
                string veterinario = txtVeterinario.Text;
                int mascotaID = int.Parse(txtMascotaID.Text);
                string adicionadoPor = txtAdicionadoPor.Text;

                // Llamar al método AgregarHistorialClinico de la clase clsHistorial
                bool resultado = clsHistorial.AgregarHistorialClinico(fechaVisita, sintomas, diagnostico, tratamiento, veterinario, mascotaID, adicionadoPor);

                // Mostrar un mensaje de éxito o error según el resultado
                if (resultado)
                {
                    Response.Write("<script>alert('Historial clínico agregado correctamente.');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Error al agregar el historial clínico.');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }

        protected void ActualizarHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                // Recoger los valores de los controles TextBox
                int historialID = int.Parse(txtHistorialID.Text);
                DateTime fechaVisita = DateTime.Parse(txtFechaVisita.Text);
                string sintomas = txtSintomas.Text;
                string diagnostico = txtDiagnostico.Text;
                string tratamiento = txtTratamiento.Text;
                string veterinario = txtVeterinario.Text;
                int mascotaID = int.Parse(txtMascotaID.Text);
                string modificadoPor = txtAdicionadoPor.Text;

                // Llamar al método ActualizarHistorialClinico de la clase clsHistorial
                bool resultado = clsHistorial.ActualizarHistorialClinico(historialID, fechaVisita, sintomas, diagnostico, tratamiento, veterinario, mascotaID, modificadoPor);

                // Mostrar un mensaje de éxito o error según el resultado
                if (resultado)
                {
                    Response.Write("<script>alert('Historial clínico actualizado correctamente.');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Error al actualizar el historial clínico.');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }

        protected void EliminarHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                int historialID = int.Parse(txtHistorialID.Text);

                // Llamar al método EliminarHistorialClinico de la clase clsHistorial
                bool resultado = clsHistorial.EliminarHistorialClinico(historialID);

                // Mostrar un mensaje de éxito o error según el resultado
                if (resultado)
                {
                    Response.Write("<script>alert('Historial clínico eliminado correctamente.');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Error al eliminar el historial clínico.');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }

        protected void VerHistorial_Click(object sender, EventArgs e)
        {
            // Aquí iría el código para redirigir a una página de historial o listar los historiales
            // Por ejemplo:
            // Response.Redirect("VerHistorial.aspx");
        }

        // Evento para redirigir a la página de gestión de mascotas
        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
