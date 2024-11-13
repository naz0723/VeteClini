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
            // Verifica si es la primera carga de la página.
            if (!IsPostBack)
            {
                // Inicialización de datos si es necesario.
            }
        }

        // Método para agregar un historial clínico
        protected void agregarHistorialClinico()
        {
            DateTime fechaVisita = DateTime.Parse(txtFechaVisita.Value);
            string sintomas = txtSintomas.Value;
            string diagnostico = txtDiagnostico.Value;
            string tratamiento = txtTratamiento.Value;
            string veterinario = txtVeterinario.Value;
            string MascotaId = txtMascotaID.Value;
            string adicionadoPor = txtAdicionadoPor.Value;

            bool agregado = clsHistorial.AgregarHistorialClinico(fechaVisita, sintomas, diagnostico, tratamiento, veterinario, Convert.ToInt32(MascotaId), adicionadoPor);

            if (agregado)
            {
                Response.Write("<script>alert('Historial clínico agregado correctamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Error al agregar el historial clínico');</script>");
            }
        }

        // Método para eliminar un historial clínico
        protected void eliminarHistorialClinico()
        {
            int historialId = Convert.ToInt32(txtHistorialIDEliminar.Value) ;

            bool eliminado = clsHistorial.EliminarHistorialClinico(historialId);

            if (eliminado)
            {
                Response.Write("<script>alert('Historial clínico eliminado correctamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Error al eliminar el historial clínico');</script>");
            }
        }

        // Método para actualizar un historial clínico
        protected void actualizarHistorialClinico()
        {
            string historialId = txtHistorialIDActualizar.Value;
            DateTime fechaVisita = DateTime.Parse(txtFechaVisitaActualizar.Value);
            string sintomas = txtSintomasActualizar.Value;
            string diagnostico = txtDiagnosticoActualizar.Value;
            string tratamiento = txtTratamientoActualizar.Value;
            string veterinario = txtVeterinarioActualizar.Value;
            string MascotaId = txtMascotaIDActualizar.Value;
            string modificadoPor = txtModificadoPor.Value;

            bool actualizado = clsHistorial.ActualizarHistorialClinico(Convert.ToInt32(historialId), fechaVisita, sintomas, diagnostico, tratamiento, veterinario, Convert.ToInt32(MascotaId), modificadoPor);

            if (actualizado)
            {
                Response.Write("<script>alert('Historial clínico actualizado correctamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Error al actualizar el historial clínico');</script>");
            }
        }
    }
}