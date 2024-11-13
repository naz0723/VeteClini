using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace VeteClini.Pages
{
    public class clsDueño
    {
        public static DatabaseHelper dh = new DatabaseHelper();

        /// <summary>
        /// Este método agrega un nuevo dueño utilizando el procedimiento almacenado sp_CrearDueño.
        /// </summary>
        public static bool Agregar(string nombre, string apellido, string direccion, string telefono, string email, string identificacion, string adicionadoPor)
        {
            try
            {
                string query = "sp_CrearDueño";

                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@Nombre", SqlDbType.NVarChar, 50) { Value = nombre },
                new SqlParameter("@Apellido", SqlDbType.NVarChar, 50) { Value = apellido },
                new SqlParameter("@Direccion", SqlDbType.NVarChar, 100) { Value = direccion },
                new SqlParameter("@Telefono", SqlDbType.NVarChar, 20) { Value = telefono },
                new SqlParameter("@Email", SqlDbType.NVarChar, 100) { Value = email },
                new SqlParameter("@Identificacion", SqlDbType.NVarChar, 20) { Value = identificacion },
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
        /// Este método actualiza un dueño existente utilizando el procedimiento almacenado sp_ActualizarDueño.
        /// </summary>
        public static bool Actualizar(int dueñoID, string nombre, string apellido, string direccion, string telefono, string email, string identificacion, string modificadoPor)
        {
            try
            {
                string query = "sp_ActualizarDueño";

                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@DueñoID", SqlDbType.Int) { Value = dueñoID },
                new SqlParameter("@Nombre", SqlDbType.NVarChar, 50) { Value = nombre },
                new SqlParameter("@Apellido", SqlDbType.NVarChar, 50) { Value = apellido },
                new SqlParameter("@Direccion", SqlDbType.NVarChar, 100) { Value = direccion },
                new SqlParameter("@Telefono", SqlDbType.NVarChar, 20) { Value = telefono },
                new SqlParameter("@Email", SqlDbType.NVarChar, 100) { Value = email },
                new SqlParameter("@Identificacion", SqlDbType.NVarChar, 20) { Value = identificacion },
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
        /// Este método elimina un dueño existente utilizando el procedimiento almacenado sp_EliminarDueño.
        /// </summary>
        public static bool Eliminar(int dueñoID)
        {
            try
            {
                string query = "sp_EliminarDueño";

                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@DueñoID", SqlDbType.Int) { Value = dueñoID }
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