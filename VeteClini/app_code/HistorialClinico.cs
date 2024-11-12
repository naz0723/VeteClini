using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace VeteClini.app_code
{
    public class HistorialClinico
    {
        public static DatabaseHelper dh = new DatabaseHelper();


        /// <summary>
        /// Este método agrega un nuevo historial clínico utilizando el procedimiento almacenado sp_CrearHistorialClinico.
        /// </summary>
        public static bool AgregarHistorialClinico(DateTime fechaVisita, string sintomas, string diagnostico, string tratamiento, string veterinario, int mascotaID, string adicionadoPor)
        {
            try
            {
                string query = "sp_CrearHistorialClinico";

                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@FechaVisita", SqlDbType.DateTime) { Value = fechaVisita },
                new SqlParameter("@Sintomas", SqlDbType.NVarChar, 250) { Value = sintomas },
                new SqlParameter("@Diagnostico", SqlDbType.NVarChar, 250) { Value = diagnostico },
                new SqlParameter("@Tratamiento", SqlDbType.NVarChar, 250) { Value = tratamiento },
                new SqlParameter("@Veterinario", SqlDbType.NVarChar, 100) { Value = veterinario },
                new SqlParameter("@MascotaID", SqlDbType.Int) { Value = mascotaID },
                new SqlParameter("@AdicionadoPor", SqlDbType.NVarChar, 50) { Value = adicionadoPor }
                };

                int rowsAffected = dh.ExecuteNonQuery(query, sqlParameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                dh.LogError(ex);
                return false;
            }
        }

        /// <summary>
        /// Este método actualiza un historial clínico existente utilizando el procedimiento almacenado sp_ActualizarHistorialClinico.
        /// </summary>
        public static bool ActualizarHistorialClinico(int historialID, DateTime fechaVisita, string sintomas, string diagnostico, string tratamiento, string veterinario, int mascotaID, string modificadoPor)
        {
            try
            {
                string query = "sp_ActualizarHistorialClinico";

                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@HistorialID", SqlDbType.Int) { Value = historialID },
                new SqlParameter("@FechaVisita", SqlDbType.DateTime) { Value = fechaVisita },
                new SqlParameter("@Sintomas", SqlDbType.NVarChar, 250) { Value = sintomas },
                new SqlParameter("@Diagnostico", SqlDbType.NVarChar, 250) { Value = diagnostico },
                new SqlParameter("@Tratamiento", SqlDbType.NVarChar, 250) { Value = tratamiento },
                new SqlParameter("@Veterinario", SqlDbType.NVarChar, 100) { Value = veterinario },
                new SqlParameter("@MascotaID", SqlDbType.Int) { Value = mascotaID },
                new SqlParameter("@ModificadoPor", SqlDbType.NVarChar, 50) { Value = modificadoPor }
                };

                int rowsAffected = dh.ExecuteNonQuery(query, sqlParameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                dh.LogError(ex);
                return false;
            }
        }

        /// <summary>
        /// Este método elimina un historial clínico existente utilizando el procedimiento almacenado sp_EliminarHistorialClinico.
        /// </summary>
        public static bool EliminarHistorialClinico(int historialID)
        {
            try
            {
                string query = "sp_EliminarHistorialClinico";

                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@HistorialID", SqlDbType.Int) { Value = historialID }
                };

                int rowsAffected = dh.ExecuteNonQuery(query, sqlParameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                dh.LogError(ex);
                return false;
            }
        }
    }
}
